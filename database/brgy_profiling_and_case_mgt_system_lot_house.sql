CREATE DATABASE  IF NOT EXISTS `brgy_profiling_and_case_mgt_system` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `brgy_profiling_and_case_mgt_system`;
-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: RUKAYYASALI    Database: brgy_profiling_and_case_mgt_system
-- ------------------------------------------------------
-- Server version	5.7.14-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `lot_house`
--

DROP TABLE IF EXISTS `lot_house`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lot_house` (
  `idlot_house` int(11) NOT NULL AUTO_INCREMENT,
  `lot_house_code` varchar(255) DEFAULT NULL,
  `lot_house_reg_date` varchar(255) DEFAULT NULL,
  `purok_idpurok` int(11) DEFAULT NULL,
  `road_idroad` int(11) DEFAULT NULL,
  `drive_iddrive` int(11) DEFAULT NULL,
  `street_idstreet` int(11) DEFAULT NULL,
  PRIMARY KEY (`idlot_house`),
  KEY `fk_lot_house_purok1_idx` (`purok_idpurok`),
  KEY `fk_lot_house_road1_idx` (`road_idroad`),
  KEY `fk_lot_house_drive1_idx` (`drive_iddrive`),
  KEY `fk_lot_house_street1_idx` (`street_idstreet`),
  CONSTRAINT `fk_lot_house_drive1` FOREIGN KEY (`drive_iddrive`) REFERENCES `drive` (`iddrive`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_lot_house_purok1` FOREIGN KEY (`purok_idpurok`) REFERENCES `purok` (`idpurok`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_lot_house_road1` FOREIGN KEY (`road_idroad`) REFERENCES `road` (`idroad`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_lot_house_street1` FOREIGN KEY (`street_idstreet`) REFERENCES `street` (`idstreet`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lot_house`
--

LOCK TABLES `lot_house` WRITE;
/*!40000 ALTER TABLE `lot_house` DISABLE KEYS */;
INSERT INTO `lot_house` VALUES (7,'L-V1IRZ1','2018-03-21',NULL,NULL,NULL,1),(8,'L-Y1QQGM','2018-03-22',NULL,NULL,NULL,1),(9,'L-LX7W0M','2018-03-23',NULL,NULL,NULL,1),(10,'L-HEAHB2','2018-03-23',NULL,NULL,NULL,1);
/*!40000 ALTER TABLE `lot_house` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-24 13:31:20
