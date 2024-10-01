/*
SQLyog Community v13.3.0 (64 bit)
MySQL - 10.4.32-MariaDB : Database - caidapresion
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`caidapresion` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;

USE `caidapresion`;

/*Table structure for table `concentracion` */

DROP TABLE IF EXISTS `concentracion`;

CREATE TABLE `concentracion` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `concentracion` */

insert  into `concentracion`(`id`,`nombre`) values 
(5,'20ppm'),
(6,'50ppm'),
(7,'75ppm'),
(8,'100ppm');

/*Table structure for table `espumante` */

DROP TABLE IF EXISTS `espumante`;

CREATE TABLE `espumante` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `espumante` */

insert  into `espumante`(`id`,`nombre`) values 
(4,'MIBC'),
(5,'AF65'),
(6,'LESS');

/*Table structure for table `espumante_concentracion` */

DROP TABLE IF EXISTS `espumante_concentracion`;

CREATE TABLE `espumante_concentracion` (
  `espumante_id` int(11) NOT NULL,
  `concentracion_id` int(11) NOT NULL,
  KEY `centracion_id` (`concentracion_id`),
  KEY `espumante_concentracion_ibfk_1` (`espumante_id`),
  CONSTRAINT `espumante_concentracion_ibfk_1` FOREIGN KEY (`espumante_id`) REFERENCES `espumante` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `espumante_concentracion_ibfk_2` FOREIGN KEY (`concentracion_id`) REFERENCES `concentracion` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `espumante_concentracion` */

insert  into `espumante_concentracion`(`espumante_id`,`concentracion_id`) values 
(4,5),
(4,6),
(4,7),
(4,8),
(5,5),
(5,6),
(5,7),
(5,8),
(6,5),
(6,6),
(6,7),
(6,8);

/*Table structure for table `grafica` */

DROP TABLE IF EXISTS `grafica`;

CREATE TABLE `grafica` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `grafica` */

insert  into `grafica`(`id`,`nombre`) values 
(1,'AirHoldup Vs Jg'),
(2,'Usg Vs Air holdup'),
(3,'Diámetro de burbuja Vs Jg');

/*Table structure for table `resultados` */

DROP TABLE IF EXISTS `resultados`;

CREATE TABLE `resultados` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `deltap` decimal(10,2) NOT NULL,
  `jsl` decimal(10,2) NOT NULL,
  `holdup` decimal(10,2) NOT NULL,
  `db` decimal(10,2) NOT NULL,
  `ub` decimal(10,2) NOT NULL,
  `reb` decimal(10,2) NOT NULL,
  `usg` decimal(10,2) NOT NULL,
  `jg` decimal(10,2) NOT NULL,
  `concentracion_id` int(11) NOT NULL,
  `espumante_id` int(11) NOT NULL,
  `grafica_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `resultados_ibfk_1` (`concentracion_id`),
  KEY `espumante_id` (`espumante_id`),
  KEY `grafica_id` (`grafica_id`),
  CONSTRAINT `resultados_ibfk_1` FOREIGN KEY (`concentracion_id`) REFERENCES `concentracion` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `resultados_ibfk_2` FOREIGN KEY (`espumante_id`) REFERENCES `espumante` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `resultados_ibfk_3` FOREIGN KEY (`grafica_id`) REFERENCES `grafica` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `resultados` */

/* Procedure structure for procedure `Insertar` */

/*!50003 DROP PROCEDURE IF EXISTS  `Insertar` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `Insertar`(
					IN _deltap DECIMAL(10,2),
					IN _jsl DECIMAL(10,2),
					IN _holdup DECIMAL(10,2),
					IN _db DECIMAL(10,2), 
					IN _ub DECIMAL(10,2),
					IN _reb DECIMAL(10,2),
					IN _usg DECIMAL(10,2),
					IN _jg DECIMAL(10,2),
					in _concentracion_id INT(11),
					IN _espumante_id int (11) )
BEGIN
		INSERT INTO `resultados`(`deltap`,`jsl`,`holdup`,`db`,`ub`,`reb`,`usg`,`jg`,`concentracion_id`,`espumante_id`)VALUES(_deltap,_jsl,_holdup,_db,_ub,_reb,_usg,_jg,_concentracion_id,_espumante_id);
	END */$$
DELIMITER ;

/*Table structure for table `view_espumante_concentracion` */

DROP TABLE IF EXISTS `view_espumante_concentracion`;

/*!50001 DROP VIEW IF EXISTS `view_espumante_concentracion` */;
/*!50001 DROP TABLE IF EXISTS `view_espumante_concentracion` */;

/*!50001 CREATE TABLE  `view_espumante_concentracion`(
 `espumante_id` int(11) ,
 `espumante` varchar(10) ,
 `concentracion_id` int(11) ,
 `concentracion` varchar(10) 
)*/;

/*View structure for view view_espumante_concentracion */

/*!50001 DROP TABLE IF EXISTS `view_espumante_concentracion` */;
/*!50001 DROP VIEW IF EXISTS `view_espumante_concentracion` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_espumante_concentracion` AS select `esp`.`id` AS `espumante_id`,`esp`.`nombre` AS `espumante`,`conc`.`id` AS `concentracion_id`,`conc`.`nombre` AS `concentracion` from ((`espumante` `esp` join `espumante_concentracion` `pivote` on(`esp`.`id` = `pivote`.`espumante_id`)) join `concentracion` `conc` on(`conc`.`id` = `pivote`.`concentracion_id`)) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
