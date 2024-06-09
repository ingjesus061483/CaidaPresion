using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using HSG.Numerics;
namespace CaidaDepresion.Utilities
{
    public abstract class Class1
    {
        //velocidad lineal del slutty (m/s)
        static  double Js1 { get { return 0.00734; } }

        //porcentaje p/p del slurry (%p/p)
        static  double Cs1 { get { return 0.025; } }

        //deltha de L, medicion del holdup (m)
        static  double dl { get { return 0.51; } }

        //deltha h, medicion del holdup (m)
        static  double dh { get { return 0.121; } }
        
        //Temperatura (K)
        static  double T { get { return 298.15; } }

        //flujo masico de alimento (g/s)
        static  double mfg { get { return 0.8333333; } }

        //flujo masico de alimento (kg/s)
        static  double mfk { get { return 0.00083333; } }

        //Bias rate (m/s)
        static  double Jb { get { return 0.001; } }

        //velocidad de agua de lavado (m/s)
        static  double Jw { get { return 0.0015; } }

        //factor Bias
        static  double Fb { get { return 0.67; } }

        //viscosidad del agua
        static  double miuw { get { return 0.00105; } }

        //peso molecular del gas
        static  double pmg { get { return 28.964; } }
        // gravedad (kg/m^2)
        static  double g { get { return 9.81; } }

        //Diametro de la particula (m)
        double dp { get { return 0.000038; } }

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
        public static  double GetCalculosHidrodinamicos(double deltap, double Jg )
        {

            if (Jg == 0)
            {
                Jg = 0.0204;
            }
            int  m = 3;
            
            //Densidad de la particula (kg/m3)
            int rop = 1230;
            
            // Presion de entrada (atm)'
            int pent = 1;
            
            //Densidad del agua (kg/m3)
            int row = 999;

            //Fraccion ocupada por la particula
            double fip = 1 / (1 + ((1 / Cs1) - 1) * (rop / row));
            
            //fraccion ocupada por el liquido
            double fil = 1 - fip;
            
            //Densidad del slurry (kg/m^3)
            double ros1 = row * fil + rop * fip;
            
            //Viscosidad del slurry (kg/m-s)
            double mius1 = miuw * Math.Pow(1 - fip, -2.5);
            
            //Densidad del aire (kg/m^3)            
            double rog = pmg * pent / (0.082 * T);
            
            //Air hold up            
            double E = 1 - (deltap / (ros1 * g * dl));

            //velocidad relativa de desplazamiento de la burbuja en el liquido (m/s)
            double Usb = Jg / E + Js1 / (1 - E);

            // velocidad terminal del gas (m/s)
            double Ut =  Usb * Math.Pow(1 - E, (1 - m));

            //Diametro de burbuja asumido
            double db0 = 0.001;

            //Tolerancia inicial
            double tol = 0.0001;


            //    double Resb = (db0 * Usb * ros1 * (1 - E)) / mius1;
            //numero de reynolds de la columna
            double Resb = 0; 
            while (tol > 1e-7)
            {
                double p1 = (18 * mius1 * Ut) / (g * (ros1 - rog)); //% Primer término de la función objetivo
                Resb = db0 * Usb * ros1 * (1 - E) / mius1; //% Re del enjambre
                double y = 1 + 0.15 * Math.Pow(Resb, 0.687); //% Segundo término de la función objetivo
                double z = Math.Pow((Usb * ros1 * (1 - E) / mius1), 0.687);// % Tercer término de la función objetivo
                double fdb = Math.Sqrt((p1 * y)) - db0; //% Función objetivo
                double ddb = 0.10305 * Math.Sqrt(p1) * Math.Pow(y, -0.5) * Math.Pow(db0, -0.313) * (z / 2) - 1; //% Derivada de la función objetivo
                double db1 = db0 - fdb / ddb;// % Nuevo diametro
                tol = Math.Abs(db1 - db0);// % Tolerancia
                db0 =db1;

            }
            double db = db0;
            //      double Ub = fsolve(@(Ub)Ub - g * db ^ 2 * (roslrog) / (18 * miusl * (1 + 0.15 * (rosl * db * Ub / miusl) ^ 0.687)),0.18,optimset('Display'
            //                                , 'off'));// % Velocidad terminal de la burbuja
            return db;
          //  return db * ros1 * Ub / mius1;
        }
    }
}
 