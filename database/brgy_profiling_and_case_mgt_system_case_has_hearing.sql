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
-- Table structure for table `case_has_hearing`
--

DROP TABLE IF EXISTS `case_has_hearing`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `case_has_hearing` (
  `idcase_has_hearing` int(11) NOT NULL AUTO_INCREMENT,
  `case_idcase` int(11) DEFAULT NULL,
  `case_complainant_idcomplainant` int(11) DEFAULT NULL,
  `case_respondent_idrespondent` int(11) DEFAULT NULL,
  `hearing_idhearing` int(11) NOT NULL,
  `case_has_hearing_remarks` varchar(255) DEFAULT NULL,
  `case_has_hearing_status` varchar(255) DEFAULT NULL,
  `case_has_hearing_witness` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idcase_has_hearing`,`hearing_idhearing`),
  KEY `fk_case_has_hearing_hearing1_idx` (`hearing_idhearing`),
  CONSTRAINT `fk_case_has_hearing_hearing1` FOREIGN KEY (`hearing_idhearing`) REFERENCES `hearing` (`idhearing`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=1880 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `case_has_hearing`
--

LOCK TABLES `case_has_hearing` WRITE;
/*!40000 ALTER TABLE `case_has_hearing` DISABLE KEYS */;
INSERT INTO `case_has_hearing` VALUES (9,8,12,10,9,'','Open',' '),(10,8,12,11,9,'','Open',' '),(11,8,13,10,9,'','Open',' '),(12,8,13,11,9,'','Open',' '),(13,9,14,12,10,'','Open',' sdf'),(14,12,18,16,13,'','Open',' '),(15,13,19,17,14,'Attended by both parties','Close','Juan Cruz'),(1878,13,19,17,1877,'','Open',' '),(1879,14,20,18,1878,'Resolved case','Close','Alice Cullen');
/*!40000 ALTER TABLE `case_has_hearing` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-24 13:31:23
