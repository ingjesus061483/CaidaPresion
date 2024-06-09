﻿using HSG.Numerics;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using HSG.Numerics;
namespace CaidaPresion.Utilities
{
    public abstract class CaidaPresion
    {
        public static double holdup { get; set; }

        public static double db { get; set; }
        
        public static double ub { get; set; }

        static double  rosl { get; set; }

        static double rog { get; set; }

        static double miusl {  get; set; }

        static int m { get { return 3; } }

        //Densidad de la particula (kg/m3)
        static double rop { get { return 1.230e3; } }

        // Presion de entrada (atm)
        static double pent { get { return 1; } }

        //Densidad del agua (kg/m3)
        static double row { get { return 999; } }      

        //porcentaje p/p del slurry (%p/p)
        static  double Cs1 { get { return 0.025; } }

        //deltha de L, medicion del holdup (m)
        static  double dl { get { return 0.51; } }
        
        //Temperatura (K)
        static  double T { get { return 298.15; } }        
       
        //viscosidad del agua
        static  double miuw { get { return 0.00105; } }

        //peso molecular del gas
        static  double pmg { get { return 28.964; } }

        // gravedad (kg/m^2)
        static  double g { get { return 9.81; } }

        //Diametro de la particula (m)
      static   double dp { get { return 0.000038; } }

        static void funcToSolveUb(int n, IntPtr x, IntPtr fx)
        {
            double[] x1 = Fsolve.MakeArray(n, x);   // Make an array for 'x' values from its Pointer
            double[] fx1 = Fsolve.MakeArray(n, fx); // Make an array for 'fx' equation/function values from its Pointer
            fx1[0]= x1[0] - g * Math.Pow(db, 2) *(rosl - rog) /(18 * miusl * (1 + 0.15 *(Math.Pow((rosl  * db  * x1[0] / miusl), 0.687))));// Write equations/functions as f(x) = 0, here it becomes x - 1 = 0
            Fsolve.CopyArray(n, fx1, fx);                // Copy fx1 array values to fx Pointer

        }
        static double getUb(Fsolve.FunctionToSolve funcUb, double tol, int unknownVariables1/* Give number of variables*/)
        {       
            double[] xGuess1 = { 0.0 };                   // Give a guess value       
            (double[] soln1, double[] fx1, string solutionCode1) = Fsolve.Fsolver(funcUb, 
                                                                                  unknownVariables1,
                                                                                  xGuess1, 
                                                                                  tol);
            return soln1[0];
        }
        

        /// <summary>
        /// /
        /// </summary>
        /// <param name="deltap">
        /// Caida de presion
        /// </param>
        /// <param name="Jg">
        /// velocidad lineal del gas (m/s)
        /// </param>
        /// <returns></returns>
        public static  double CalcularValorReynold(double deltap, double Jg,double jsl )
        {

            if (Jg == 0)
            {
                Jg = 0.0204;
            }           

            //Fraccion ocupada por la particula
            double fip = 1 / (1 + ((1 / Cs1) - 1) * (rop / row));
            
            //fraccion ocupada por el liquido
            double fil = 1 - fip;
            
            //Densidad del slurry (kg/m^3)
             rosl = row * fil + rop * fip;
            
            //Viscosidad del slurry (kg/m-s)
             miusl = miuw * Math.Pow(1 - fip, -2.5);
            
            //Densidad del aire (kg/m^3)            
             rog = pmg * pent / (0.082 * T);

            //Air hold up            
            holdup = 1 - (deltap / (rosl * g * dl));

            //velocidad relativa de desplazamiento de la burbuja en el liquido (m/s)
            double Usb = Jg / holdup  + jsl / (1 - holdup);

            // velocidad terminal del gas (m/s)
            double Ut =  Usb * Math.Pow(1 - holdup, (1 - m));

            //Diametro de burbuja asumido
            double db0 = 0.001;

            //Tolerancia inicial
            double tol = 0.0001;            
            double Resb = 0; 
            while (tol > 1e-9)
            {
                double p1 = (18 * miusl * Ut) / (g * (rosl - rog)); //% Primer término de la función objetivo
                Resb = db0 * Usb * rosl * (1 - holdup) / miusl; //% Re del enjambre
                double y = 1 + 0.15 * Math.Pow(Resb, 0.687); //% Segundo término de la función objetivo
                double z = Math.Pow((Usb * rosl * (1 - holdup) / miusl), 0.687);// % Tercer término de la función objetivo
                double fdb = Math.Sqrt((p1 * y)) - db0; //% Función objetivo
                double ddb = 0.10305 * Math.Sqrt(p1) * Math.Pow(y, -0.5) * Math.Pow(db0, -0.313) * (z / 2) - 1; //% Derivada de la función objetivo
                double db1 = db0 - fdb / ddb;// % Nuevo diametro
                tol = Math.Abs(db1 - db0);// % Tolerancia
                db0 =db1;
            }
            db = db0;
            // Give number of variables
            int unknownVariables1 = 1;

            // Wrap function so it can be called
            Fsolve.FunctionToSolve funcUb = new(funcToSolveUb);        

            ub = getUb(funcUb, tol, unknownVariables1);
            return db * rosl * ub  / miusl;       
        }
        public static DataTable GetDataTable(string[] columns )
        {
            DataTable dt = new DataTable();
            for (int i = 0; i <= columns.Length - 1;i++)
            {
                dt.Columns.Add(columns[i]);
            }
 
            return dt;
        }
        public static  void SetRow(DataTable dt, string[] column, string[] values)
        {
            DataRow row = dt.NewRow();
            row[column [0]] = values[0];
            row[column[1]] = values[1];
            dt.Rows.Add(row);
        }
        public static DataTable getInitialValues()
        {
            string[] columns = { "Variable", "Resultado" };
            DataTable dt = GetDataTable(columns);
            string[] values = { "Densidad de la particula (kg/m3)", rop.ToString() };
            SetRow(dt, columns, values);
            string[] values2 = { "Densidad del slurry (kg/m^3)", rosl.ToString() };
            SetRow(dt, columns, values2);
            string[] values3 = { "Densidad del aire (kg/m^3)", rog.ToString() };
            SetRow(dt, columns, values3);
            string[] value4 = { "Viscosidad del slurry (kg/m-s)", miusl.ToString() };
            SetRow (dt, columns, value4);
            string[] values5 = {"m",m.ToString() };
            SetRow(dt, columns, values5);
            string[] values6 = { "Densidad de la particula (kg/m3)", rog.ToString() }; 
            SetRow(dt , columns, values6);
            string[] values7 = { "Presion de entrada (atm)", pent.ToString() };
            SetRow(dt , columns, values7);
            string[] values8 = { "Densidad del agua (kg/m3)", row .ToString()};
            SetRow(dt , columns, values8);
            string[] values9 = { "Porcentaje p/p del slurry (%p/p)", Cs1.ToString() };
            SetRow(dt , columns, values9);
            string[] values10 = { "Deltha de L, medicion del holdup (m)", dl.ToString() };
            SetRow(dt , columns, values10);
            string[] values11 = { "Temperatura (K)", T.ToString() };
            SetRow (dt , columns, values11);
            string[] values12 = { "Viscosidad del agua(Kg/ms",miuw.ToString() };
            SetRow(dt , columns, values12);
            string[] values13 = { "Peso molecular del gas (kg/kmol)", pmg.ToString() };
            SetRow(dt , columns, values13);
            string[] values14 = { "gravedad (kg/m^2)",g.ToString() };
            SetRow(dt , columns, values14);
            string[] values15 = { "Diametro de la particula (m)", dp.ToString() };
            SetRow(dt , columns, values15);
            return dt;

        }

    }
}
 