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
-- Table structure for table `person_has_business_est`
--

DROP TABLE IF EXISTS `person_has_business_est`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `person_has_business_est` (
  `idperson_has_business_est` varchar(255) DEFAULT NULL,
  `person_idperson` int(11) NOT NULL,
  `business_est_idbusiness_est` int(11) NOT NULL,
  `person_has_business_est_representative` varchar(255) DEFAULT NULL COMMENT 'true or false',
  PRIMARY KEY (`person_idperson`,`business_est_idbusiness_est`),
  KEY `fk_person_has_business_est_business_est1_idx` (`business_est_idbusiness_est`),
  KEY `fk_person_has_business_est_person1_idx` (`person_idperson`),
  CONSTRAINT `fk_person_has_business_est_business_est1` FOREIGN KEY (`business_est_idbusiness_est`) REFERENCES `business_est` (`idbusiness_est`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_person_has_business_est_person1` FOREIGN KEY (`person_idperson`) REFERENCES `person` (`idperson`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `person_has_business_est`
--

LOCK TABLES `person_has_business_est` WRITE;
/*!40000 ALTER TABLE `person_has_business_est` DISABLE KEYS */;
/*!40000 ALTER TABLE `person_has_business_est` ENABLE KEYS */;
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
