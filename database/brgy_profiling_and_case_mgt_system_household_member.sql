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
-- Table structure for table `household_member`
--

DROP TABLE IF EXISTS `household_member`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `household_member` (
  `idhousehold_member` int(11) NOT NULL AUTO_INCREMENT,
  `household_idhousehold` int(11) NOT NULL,
  `person_idperson` int(11) NOT NULL,
  `household_member_role` varchar(255) DEFAULT NULL,
  `household_member_reg_date` date DEFAULT NULL,
  `household_member_is_head` varchar(255) DEFAULT NULL,
  `household_member_head_status` varchar(255) DEFAULT NULL COMMENT 'para malaman kung active pa yung certain head',
  PRIMARY KEY (`idhousehold_member`,`household_idhousehold`,`person_idperson`),
  KEY `fk_family_has_person_person1_idx` (`person_idperson`),
  KEY `fk_family_has_person_family1_idx` (`household_idhousehold`),
  CONSTRAINT `fk_family_has_person_family1` FOREIGN KEY (`household_idhousehold`) REFERENCES `household` (`idhousehold`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_family_has_person_person1` FOREIGN KEY (`person_idperson`) REFERENCES `person` (`idperson`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `household_member`
--

LOCK TABLES `household_member` WRITE;
/*!40000 ALTER TABLE `household_member` DISABLE KEYS */;
INSERT INTO `household_member` VALUES (25,8,45,'Child','2018-03-21','True','Active'),(26,8,46,'Sibling','2018-03-21','False',' '),(27,9,46,'Sibling','2018-03-22','True','Active'),(28,9,49,'Sibling','2018-03-22','False',' '),(29,9,51,'Sibling','2018-03-22','False',' '),(30,9,60,'Parent','2018-03-22','False',' '),(31,8,61,'Child','2018-03-22','False',' '),(32,10,66,'Parent','2018-03-23','True','Active'),(33,10,67,'Parent','2018-03-23','False',' '),(34,10,68,'Child','2018-03-23','False',' '),(35,11,69,'Parent','2018-03-23','True','Active'),(36,11,70,'Parent','2018-03-23','False',' '),(37,11,71,'Child','2018-03-23','False',' ');
/*!40000 ALTER TABLE `household_member` ENABLE KEYS */;
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
