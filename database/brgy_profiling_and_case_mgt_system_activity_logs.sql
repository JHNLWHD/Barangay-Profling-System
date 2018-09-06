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
-- Table structure for table `activity_logs`
--

DROP TABLE IF EXISTS `activity_logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `activity_logs` (
  `idactivity_logs` int(11) NOT NULL AUTO_INCREMENT,
  `activity_logs_myact_name` varchar(255) DEFAULT NULL,
  `activity_logs_act_name` varchar(255) DEFAULT NULL,
  `activity_logs_date` datetime DEFAULT NULL,
  `account_idaccount` int(11) NOT NULL,
  PRIMARY KEY (`idactivity_logs`),
  KEY `fk_activity_logs_account_idx` (`account_idaccount`),
  CONSTRAINT `fk_activity_logs_account` FOREIGN KEY (`account_idaccount`) REFERENCES `account` (`idaccount`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `activity_logs`
--

LOCK TABLES `activity_logs` WRITE;
/*!40000 ALTER TABLE `activity_logs` DISABLE KEYS */;
INSERT INTO `activity_logs` VALUES (1,'You have saved new street: Street 1','admin have saved new street: Street 1','2018-03-15 21:08:04',1),(2,'You have saved new house: RBJUH8','admin have saved new house: RBJUH8','2018-03-15 21:08:18',1),(3,'You have saved new resident: asdasd asdas adax asda','admin have saved new resident: asdasd asdas adax asda','2018-03-16 15:41:13',1),(4,'You have saved new resident: Kali K Medzna ','admin have saved new resident: Kali K Medzna ','2018-03-16 15:50:50',1),(5,'You have saved new house: BID857','admin have saved new house: BID857','2018-03-16 18:35:58',1),(6,'You have saved new house: EYTN1S','admin have saved new house: EYTN1S','2018-03-16 18:38:25',1),(7,'You have saved new household: H-CZOXOEI','admin have saved new household: H-CZOXOEI','2018-03-16 18:41:07',1),(8,'You have saved new resident: Ron  Weasley ','admin have saved new resident: Ron  Weasley ','2018-03-16 18:44:12',1),(9,'You have saved new religion: Islam','admin have saved new religion: Islam','2018-03-20 12:18:58',1),(10,'You have saved new tribe: Tausug','admin have saved new tribe: Tausug','2018-03-20 12:19:10',1),(11,'You have saved new occupation: Student','admin have saved new occupation: Student','2018-03-20 12:19:22',1),(12,'You have saved new occupation: GradWAITING','admin have saved new occupation: GradWAITING','2018-03-20 12:19:39',1),(13,'You have saved new resident: Rukayya Muctar Sali ','admin have saved new resident: Rukayya Muctar Sali ','2018-03-20 12:21:12',1),(14,'You have saved new resident: Farouk Alibasa Sali ','admin have saved new resident: Farouk Alibasa Sali ','2018-03-20 12:57:03',1),(15,'You have saved new house: XMSUMJ','admin have saved new house: XMSUMJ','2018-03-20 15:27:01',1),(16,'You have saved new household: H-PBCJ99F','admin have saved new household: H-PBCJ99F','2018-03-20 15:27:32',1),(17,'You have saved new occupation: Housewife','admin have saved new occupation: Housewife','2018-03-20 15:28:56',1),(18,'You have saved new religion: Roman Catholic','admin have saved new religion: Roman Catholic','2018-03-20 15:29:12',1),(19,'You have saved new tribe: Christian','admin have saved new tribe: Christian','2018-03-20 15:29:23',1),(20,'You have saved new resident: Lily  Potter ','admin have saved new resident: Lily  Potter ','2018-03-20 15:33:08',1),(21,'You have saved new resident: Harry  Potter ','admin have saved new resident: Harry  Potter ','2018-03-20 15:35:11',1),(22,'You have saved new resident: Ginie  Weasley ','admin have saved new resident: Ginie  Weasley ','2018-03-20 15:39:12',1),(23,'You have saved new resident: Sitti Muctar Sali ','admin have saved new resident: Sitti Muctar Sali ','2018-03-21 00:26:11',1),(24,'You have saved new house: 895R3I','admin have saved new house: 895R3I','2018-03-21 14:15:37',1),(25,'You have saved new household: H-6YTRCUE','admin have saved new household: H-6YTRCUE','2018-03-21 14:16:12',1),(26,'You have saved new resident: Narcisa  Malfoy ','admin have saved new resident: Narcisa  Malfoy ','2018-03-21 14:22:06',1),(27,'You have saved new spouse:    ','admin have saved new spouse:    ','2018-03-21 14:23:11',1),(28,'You have saved new resident: Draco  Malfoy ','admin have saved new resident: Draco  Malfoy ','2018-03-21 14:24:20',1),(29,'You have saved new house: E89C9U','admin have saved new house: E89C9U','2018-03-21 14:29:28',1),(30,'You have saved new household: H-28863SN','admin have saved new household: H-28863SN','2018-03-21 14:29:49',1),(31,'You have saved new resident: Astoria  Greengrass ','admin have saved new resident: Astoria  Greengrass ','2018-03-21 14:30:40',1),(32,'You have saved new resident: Ahmad Muctar Sali ','admin have saved new resident: Ahmad Muctar Sali ','2018-03-21 23:29:37',1),(33,'You have saved new house: V1IRZ1','admin have saved new house: V1IRZ1','2018-03-21 23:46:46',1),(34,'You have saved new household: H-AHQU657','admin have saved new household: H-AHQU657','2018-03-21 23:47:11',1),(35,'You have saved new resident: Ahmad Muctar Sali ','admin have saved new resident: Ahmad Muctar Sali ','2018-03-21 23:49:34',1),(36,'You have saved new house: Y1QQGM','admin have saved new house: Y1QQGM','2018-03-22 00:01:11',1),(37,'You have saved new household: H-YX1F3V3','admin have saved new household: H-YX1F3V3','2018-03-22 00:01:37',1),(38,'You have saved new resident: Harry  Potter ','admin have saved new resident: Harry  Potter ','2018-03-22 00:03:21',1),(39,'You have saved new resident: Ron  Wisley ','admin have saved new resident: Ron  Wisley ','2018-03-22 00:07:23',1),(40,'You have saved new spouse:    ','admin have saved new spouse:    ','2018-03-22 00:49:03',1),(41,'You have saved new resident: s s s ','admin have saved new resident: s s s ','2018-03-22 00:55:14',1),(42,'You have saved new resident: a a a ','admin have saved new resident: a a a ','2018-03-22 00:55:52',1),(43,'You have saved new spouse:    ','admin have saved new spouse:    ','2018-03-22 00:56:13',1),(44,'You have saved new spouse:    ','admin have saved new spouse:    ','2018-03-22 00:59:34',1),(45,'You have saved new house: LX7W0M','admin have saved new house: LX7W0M','2018-03-23 12:49:34',1),(46,'You have saved new household: H-LO6V5A3','admin have saved new household: H-LO6V5A3','2018-03-23 12:50:02',1),(47,'You have saved new resident: Rene  Cullen ','admin have saved new resident: Rene  Cullen ','2018-03-23 12:52:29',1),(48,'You have saved new resident: Edward  Cullen ','admin have saved new resident: Edward  Cullen ','2018-03-23 12:53:44',1),(49,'You have saved new house: HEAHB2','admin have saved new house: HEAHB2','2018-03-23 12:55:58',1),(50,'You have saved new household: H-0WVLB3R','admin have saved new household: H-0WVLB3R','2018-03-23 12:56:15',1),(51,'You have saved new resident: Esmee  Swan ','admin have saved new resident: Esmee  Swan ','2018-03-23 12:57:37',1),(52,'You have saved new resident: Elizabeth  Swan ','admin have saved new resident: Elizabeth  Swan ','2018-03-23 12:59:17',1),(53,'You have saved new spouse:    ','admin have saved new spouse:    ','2018-03-24 13:19:34',1);
/*!40000 ALTER TABLE `activity_logs` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-03-24 13:31:27
