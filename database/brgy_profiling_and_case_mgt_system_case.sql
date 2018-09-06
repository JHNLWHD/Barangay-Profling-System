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
-- Table structure for table `case`
--

DROP TABLE IF EXISTS `case`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `case` (
  `idcase` int(11) NOT NULL AUTO_INCREMENT,
  `complainant_idcomplainant` int(11) NOT NULL,
  `respondent_idrespondent` int(11) NOT NULL,
  `case_code` varchar(255) DEFAULT NULL,
  `case_type` varchar(255) DEFAULT NULL,
  `case_desc` varchar(255) DEFAULT NULL,
  `case_date_received` date DEFAULT NULL,
  `case_remarks` varchar(255) DEFAULT NULL,
  `case_report` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idcase`,`complainant_idcomplainant`,`respondent_idrespondent`),
  KEY `fk_complainant_has_respondent_respondent1_idx` (`respondent_idrespondent`),
  KEY `fk_complainant_has_respondent_complainant1_idx` (`complainant_idcomplainant`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `case`
--

LOCK TABLES `case` WRITE;
/*!40000 ALTER TABLE `case` DISABLE KEYS */;
INSERT INTO `case` VALUES (8,0,0,'CS3','Pervert','Manyakul','2018-03-22','Open',NULL),(9,0,0,'CS2','ROBBERY','Ninakaw ang puso ko','2018-03-22','Open',NULL),(12,0,0,'CS4','ret','ter','2018-03-22','Open',NULL),(13,0,0,'CS5','ter','dasdasdsasddasdasdasdasdasdasdasd','2018-03-22','Open',NULL),(14,0,0,'COO1','Public Dsiturbance','Loud videoke','2018-03-23','Re-Open','Case reschedule');
/*!40000 ALTER TABLE `case` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-24 13:31:26
