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
-- Table structure for table `relative`
--

DROP TABLE IF EXISTS `relative`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `relative` (
  `idrelative` int(11) NOT NULL AUTO_INCREMENT,
  `relative_role` varchar(255) DEFAULT NULL,
  `relative_idperson` int(11) DEFAULT NULL,
  `relative_date_of_marriage` date DEFAULT NULL,
  `person_idperson` int(11) NOT NULL,
  PRIMARY KEY (`idrelative`),
  KEY `fk_relative_person1_idx` (`person_idperson`),
  CONSTRAINT `fk_relative_person1` FOREIGN KEY (`person_idperson`) REFERENCES `person` (`idperson`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `relative`
--

LOCK TABLES `relative` WRITE;
/*!40000 ALTER TABLE `relative` DISABLE KEYS */;
INSERT INTO `relative` VALUES (12,'Sibling',47,NULL,46),(13,'Sibling',46,NULL,47),(14,'Parent',48,NULL,46),(15,'Parent',46,NULL,48),(16,'Spouse',50,'2017-03-22',49),(17,'Spouse',49,'2017-03-22',50),(18,'Spouse',52,'1997-03-22',51),(19,'Spouse',51,'1997-03-22',52),(30,'Spouse',59,'2010-03-22',46),(31,'Spouse',46,'2010-03-22',59),(32,'Spouse',62,'2010-03-22',60),(33,'Spouse',60,'2010-03-22',62),(34,'Spouse',63,'2018-03-22',60),(35,'Spouse',60,'2018-03-22',63),(36,'Spouse',66,'1944-06-13',67),(37,'Spouse',67,'1944-06-13',66),(38,'Spouse',69,'1944-06-13',70),(39,'Spouse',70,'1944-06-13',69),(40,'Parent',69,NULL,71),(41,'Parent',71,NULL,69),(42,'Parent',70,NULL,71),(43,'Parent',71,NULL,70),(47,'Spouse',68,'2018-03-24',71),(48,'Spouse',71,'2018-03-24',68);
/*!40000 ALTER TABLE `relative` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-24 13:31:21
