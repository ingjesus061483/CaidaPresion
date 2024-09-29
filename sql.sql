/*
SQLyog Community v13.2.1 (64 bit)
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
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
					IN _jg DECIMAL(10,2))
BEGIN
		INSERT INTO `resultados`(`deltap`,`jsl`,`holdup`,`db`,`ub`,`reb`,`usg`,`jg`)VALUES(_deltap,_jsl,_holdup,_db,_ub,_reb,_usg,_jg);
	END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
