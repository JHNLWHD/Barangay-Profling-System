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
-- Table structure for table `person`
--

DROP TABLE IF EXISTS `person`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `person` (
  `idperson` int(11) NOT NULL AUTO_INCREMENT,
  `person_last_name` varchar(255) DEFAULT NULL,
  `person_first_name` varchar(255) DEFAULT NULL,
  `person_middle_name` varchar(255) DEFAULT NULL,
  `person_extension_name` varchar(255) DEFAULT NULL,
  `person_gender` varchar(255) DEFAULT NULL,
  `person_mobile_no` varchar(255) DEFAULT NULL,
  `person_tel_no` varchar(255) DEFAULT NULL,
  `person_civil_status` varchar(255) DEFAULT NULL,
  `person_date_of_birth` date DEFAULT NULL,
  `religion_idreligion` int(11) DEFAULT NULL,
  `tribe_idtribe` int(11) DEFAULT NULL,
  `occupation_idoccupation` int(11) DEFAULT NULL,
  `person_status` varchar(255) DEFAULT NULL,
  `person_reg_date_resident` date DEFAULT NULL,
  `person_reg_date` date DEFAULT NULL,
  `person_voter_status` varchar(255) DEFAULT NULL,
  `person_precinct_number` varchar(255) DEFAULT NULL,
  `person_place_of_birth` varchar(255) DEFAULT NULL,
  `person_height` varchar(255) DEFAULT NULL,
  `person_weight` varchar(255) DEFAULT NULL,
  `person_complexion` varchar(255) DEFAULT NULL,
  `person_hair_color` varchar(255) DEFAULT NULL,
  `person_eye_color` varchar(255) DEFAULT NULL,
  `person_image` longblob,
  `person_vital_status` varchar(255) DEFAULT NULL,
  `person_code` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idperson`),
  KEY `fk_person_religion1_idx` (`religion_idreligion`),
  KEY `fk_person_tribe1_idx` (`tribe_idtribe`),
  KEY `fk_person_occupation1_idx` (`occupation_idoccupation`),
  CONSTRAINT `fk_person_occupation1` FOREIGN KEY (`occupation_idoccupation`) REFERENCES `occupation` (`idoccupation`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_person_religion1` FOREIGN KEY (`religion_idreligion`) REFERENCES `religion` (`idreligion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_person_tribe1` FOREIGN KEY (`tribe_idtribe`) REFERENCES `tribe` (`idtribe`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `person`
--

LOCK TABLES `person` WRITE;
/*!40000 ALTER TABLE `person` DISABLE KEYS */;
INSERT INTO `person` VALUES (1,'Wahid','Al-Jhoenil',' ',' ','Male','098979097','9999','Married','1998-05-17',NULL,NULL,NULL,'Resident','2018-03-15','2018-03-15',' ',' ',' ',' ',' ',' ',' ',' ',NULL,'Alive','P-123DR'),(45,'Sali','Rukayya','Muctar','','Female','09157682247','2005656','Married','1997-03-21',NULL,NULL,NULL,'Resident','2018-03-21','2018-03-21','','','','','','','','',NULL,'Alive',NULL),(46,'Sali','Ahmad','Muctar','','Male','Student','2006969','Married','1992-03-21',NULL,NULL,NULL,'Resident','2018-03-21','2018-03-21','Non Voter','','Isabela City','152','40',NULL,'','',NULL,'Alive','P-EIBUJI'),(47,'Muctar','Sali','Faridah','','Female','','','Married','2018-01-01',NULL,NULL,NULL,'Resident','2018-03-21','2018-03-21','','','','','','','','',NULL,'Alive','P-EIBUJI'),(48,'Muctar','Sali','Ummicalsum','','Female','','','Married','2018-01-01',NULL,NULL,NULL,'Resident','2018-03-21','2018-03-21','','','','','','','','',NULL,'Alive','P-EIBUJI'),(49,'Potter','Harry','','','Male','Student','','Married','1997-03-22',NULL,NULL,NULL,'Resident','2018-03-22','2018-03-22','Non Voter','','New York','','',NULL,'','',NULL,'Alive','P-JIKWMO'),(50,'','Wisley','Genie','','Female','','','Married','2018-01-01',NULL,NULL,NULL,'Non Resident','2018-03-22','2018-03-22','','','','','','','','',NULL,'Alive','P-JIKWMO'),(51,'Wisley','Ron','','','Male','Student','','Married','1998-03-22',NULL,NULL,NULL,'Resident','2018-03-22','2018-03-22','Non Voter','','Washington','','',NULL,'','',NULL,'Alive','P-CYVRFS'),(52,'','Watson','Emma','','Female','','','Married','2018-01-01',NULL,NULL,NULL,'Non Resident','2018-03-22','2018-03-22','','','','','','','','',NULL,'Alive','P-CYVRFS'),(59,'Aming','April','Sevilla','','Female','','','Married','1995-03-22',NULL,NULL,NULL,'Resident','2018-03-22','2018-03-22','','','','','','','','',NULL,'Alive',NULL),(60,'s','s','s','','Male','GradWAITING','','Married','2018-03-22',NULL,NULL,NULL,'Resident','2018-03-22','2018-03-22','Non Voter','','s','','',NULL,'','',NULL,'Alive','P-HLRRQZ'),(61,'a','a','a','','Male','GradWAITING','','Single','2018-03-22',NULL,NULL,NULL,'Resident','2018-03-22','2018-03-22','Non Voter','','a','','',NULL,'','',NULL,'Alive','P-LDOIQD'),(62,'c','c','c','c','Female','','','Married','1992-03-22',NULL,NULL,NULL,'Resident','2018-03-22','2018-03-22','','','','','','','','',NULL,'Alive',NULL),(63,'','','','','Male','','','Married','2018-03-22',NULL,NULL,NULL,'Non Resident',NULL,'2018-03-22','','','','','','','','',NULL,'Alive',NULL),(64,'','Araneta','Ivy','','Female','','','','2017-01-01',NULL,NULL,NULL,'Resident','2018-03-22','2018-03-22','','','','','','','','',NULL,'Alive',NULL),(65,'','Paelmariano','Rizza','','Female','','','','2017-01-01',NULL,NULL,NULL,'Resident','2018-03-22','2018-03-22','','','','','','','','',NULL,'Alive',NULL),(66,'Cullen','Carlisle','','','Male','9890771293','999999','Married','1900-03-06',NULL,NULL,NULL,'Resident','2018-03-23','2018-03-23','','','','','','','','',NULL,'Alive',NULL),(67,'Cullen','Rene','','','Female','099089797','999999','Married','1900-01-30',NULL,NULL,NULL,'Resident','2018-03-23','2018-03-23','Non Voter','','ZXX','','',NULL,'','',NULL,'Alive','P-UDEDWN'),(68,'Cullen','Edward','','','Male','3435435435346','89999','Married','1954-06-15',NULL,NULL,NULL,'Resident','2018-03-23','2018-03-23','Non Voter','','ZXX','','',NULL,'','',NULL,'Alive','P-RAMZOF'),(69,'Swan','Charlie','','','Male','98907712933','99999923','Married','1969-05-05',NULL,NULL,NULL,'Resident','2018-03-23','2018-03-23','','','','','','','','',NULL,'Alive',NULL),(70,'Swan','Esmee','','','Female','6575685858','999999','Married','1984-06-12',NULL,NULL,NULL,'Resident','2018-03-23','2018-03-23','Non Voter','','xcz','','',NULL,'','',NULL,'Alive','P-XQQMAV'),(71,'Swan','Elizabeth','','','Female','64577657','54654745745','Married','1999-06-15',NULL,NULL,NULL,'Resident','2018-03-23','2018-03-23','Non Voter','','zzxz','','',NULL,'','',NULL,'Alive','P-GLJHOF');
/*!40000 ALTER TABLE `person` ENABLE KEYS */;
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
