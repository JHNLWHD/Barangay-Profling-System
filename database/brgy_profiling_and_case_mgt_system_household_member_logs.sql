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
-- Table structure for table `household_member_logs`
--

DROP TABLE IF EXISTS `household_member_logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `household_member_logs` (
  `idhousehold_member_logs` int(11) NOT NULL AUTO_INCREMENT,
  `household_member_logs_desc` varchar(255) DEFAULT NULL,
  `household_member_logs_reg_date` date DEFAULT NULL,
  `household_member_idhousehold_member` int(11) NOT NULL,
  `household_member_household_idhousehold` int(11) NOT NULL,
  `household_member_person_idperson` int(11) NOT NULL,
  PRIMARY KEY (`idhousehold_member_logs`,`household_member_idhousehold_member`,`household_member_household_idhousehold`,`household_member_person_idperson`),
  KEY `fk_household_member_logs_household_member1_idx` (`household_member_idhousehold_member`,`household_member_household_idhousehold`,`household_member_person_idperson`),
  CONSTRAINT `fk_household_member_logs_household_member1` FOREIGN KEY (`household_member_idhousehold_member`, `household_member_household_idhousehold`, `household_member_person_idperson`) REFERENCES `household_member` (`idhousehold_member`, `household_idhousehold`, `person_idperson`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `household_member_logs`
--

LOCK TABLES `household_member_logs` WRITE;
/*!40000 ALTER TABLE `household_member_logs` DISABLE KEYS */;
/*!40000 ALTER TABLE `household_member_logs` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-24 13:31:25
