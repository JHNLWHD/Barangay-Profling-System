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
-- Table structure for table `house_history`
--

DROP TABLE IF EXISTS `house_history`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `house_history` (
  `idhouse_history` int(11) NOT NULL AUTO_INCREMENT,
  `house_history_desc` varchar(255) DEFAULT NULL,
  `house_history_date` date DEFAULT NULL,
  `house_idhouse` int(11) NOT NULL,
  PRIMARY KEY (`idhouse_history`),
  KEY `fk_house_history_house1_idx` (`house_idhouse`),
  CONSTRAINT `fk_house_history_house1` FOREIGN KEY (`house_idhouse`) REFERENCES `house` (`idhouse`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `house_history`
--

LOCK TABLES `house_history` WRITE;
/*!40000 ALTER TABLE `house_history` DISABLE KEYS */;
INSERT INTO `house_history` VALUES (7,'House number: V1IRZ1 is registered on this date: 3/21/2018 that has 2 floor/s with Legal Settler status and it is Residential. This house is owned by Rukayya Muctar Sali  under lot number L-V1IRZ1.','2018-03-21',7),(8,'House number: Y1QQGM is registered on this date: 3/22/2018 that has 1 floor/s with Legal Settler status and it is Residential. This house is owned by Ahmad Muctar Sali  under lot number L-Y1QQGM.','2018-03-22',8),(9,'House number: LX7W0M is registered on this date: 3/23/2018 that has 10 floor/s with Legal Settler status and it is Residential. This house is owned by Carlisle  Cullen  under lot number L-LX7W0M.','2018-03-23',9),(10,'House number: HEAHB2 is registered on this date: 3/23/2018 that has 2 floor/s with Legal Settler status and it is Residential. This house is owned by Charlie  Swan  under lot number L-HEAHB2.','2018-03-23',10);
/*!40000 ALTER TABLE `house_history` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-24 13:31:28
