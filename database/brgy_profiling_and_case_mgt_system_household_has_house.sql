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
-- Table structure for table `household_has_house`
--

DROP TABLE IF EXISTS `household_has_house`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `household_has_house` (
  `idhousehold_has_house` int(11) NOT NULL AUTO_INCREMENT,
  `household_idhousehold` int(11) NOT NULL,
  `house_idhouse` int(11) NOT NULL,
  `household_has_house_reg_date` date DEFAULT NULL,
  `household_has_house_status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idhousehold_has_house`,`household_idhousehold`,`house_idhouse`),
  KEY `fk_household_has_house_house1_idx` (`house_idhouse`),
  KEY `fk_household_has_house_household1_idx` (`household_idhousehold`),
  CONSTRAINT `fk_household_has_house_house1` FOREIGN KEY (`house_idhouse`) REFERENCES `house` (`idhouse`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_household_has_house_household1` FOREIGN KEY (`household_idhousehold`) REFERENCES `household` (`idhousehold`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `household_has_house`
--

LOCK TABLES `household_has_house` WRITE;
/*!40000 ALTER TABLE `household_has_house` DISABLE KEYS */;
INSERT INTO `household_has_house` VALUES (8,8,7,'2018-03-21','Active'),(9,9,8,'2018-03-22','Active'),(10,10,9,'2018-03-23','Active'),(11,11,10,'2018-03-23','Active');
/*!40000 ALTER TABLE `household_has_house` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-24 13:31:19
