CREATE DATABASE  IF NOT EXISTS `rozpocet_tool` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `rozpocet_tool`;
-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: 34.154.22.180    Database: rozpocet_tool
-- ------------------------------------------------------
-- Server version	8.0.26-google

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
SET @MYSQLDUMP_TEMP_LOG_BIN = @@SESSION.SQL_LOG_BIN;
SET @@SESSION.SQL_LOG_BIN= 0;

--
-- GTID state at the beginning of the backup 
--

SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ 'a2cd4872-d3d0-11ed-b65d-42010a400004:1-122427';

--
-- Table structure for table `code`
--

DROP TABLE IF EXISTS `code`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `code` (
  `c` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`c`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `code`
--

LOCK TABLES `code` WRITE;
/*!40000 ALTER TABLE `code` DISABLE KEYS */;
INSERT INTO `code` VALUES ('BVYS-9NWX-XZS1-Y0GB'),('H0DJ-842M-P6K6-Q1IL'),('MD7G-4HXU-QNG2-1CPA'),('MNM1-XJ8P-BBNR-DM7H'),('WJTP-P7YB-O2L8-ZI6D'),('WP6K-2LPD-80P3-IRSJ'),('ZX7O-7EBC-FTRV-SOD0');
/*!40000 ALTER TABLE `code` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`34.154.22.180`*/ /*!50003 TRIGGER `use_code` BEFORE DELETE ON `code` FOR EACH ROW insert into used_code(c) values(old.c) */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `produkt`
--

DROP TABLE IF EXISTS `produkt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produkt` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nazev` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `rozpocet_id` int NOT NULL,
  `jednotka` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `pocet` double NOT NULL,
  `cena` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produkt`
--

LOCK TABLES `produkt` WRITE;
/*!40000 ALTER TABLE `produkt` DISABLE KEYS */;
INSERT INTO `produkt` VALUES (14,'hjgh',1,'m2',58,52),(22,'jghghj',0,'m2',52,25),(23,'Betonářská ocel Ø 12 mm rovná – 6 m',0,'ks',59,155),(24,'Deska OSB 3 PD Kronospan nebroušená – 2500 × 625 × 12 mm',45,'ks',48,276),(25,'Bednění ztracené DITON – 500 × 300 × 250 mm',45,'ks',25,71),(28,'Boba',47,'kg',20,5),(36,'Betonářská ocel Ø 10 mm rovná –  6m',48,'ks',150,107),(42,'Betonářská ocel Ø 12 mm rovná – 6 m',49,'ks',15,155),(43,'Autohouba hranatá – 20 × 14 × 7 cm',49,'ks',15,57),(44,'Autohouba hranatá – 20 × 14 × 7 cm',49,'ks',15,57),(45,'Cihla Porotherm 30 Profi Dryfix P10 – 247 × 300 × 249 mm',43,'ks',9,87);
/*!40000 ALTER TABLE `produkt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rozpocet`
--

DROP TABLE IF EXISTS `rozpocet`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rozpocet` (
  `id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `datum` date NOT NULL,
  `jmeno_zak` varchar(45) COLLATE utf8mb4_general_ci NOT NULL,
  `prijmeni_zak` varchar(45) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=50 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rozpocet`
--

LOCK TABLES `rozpocet` WRITE;
/*!40000 ALTER TABLE `rozpocet` DISABLE KEYS */;
INSERT INTO `rozpocet` VALUES (43,5,'2023-03-18','Dan','Hrubý'),(45,5,'2023-03-27','Dan','Hřubý'),(47,10,'2023-03-27','Dan','Hřubý'),(48,10,'2023-03-28','Dan','Hřubý'),(49,5,'2023-04-12','Jan','Hehl');
/*!40000 ALTER TABLE `rozpocet` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `used_code`
--

DROP TABLE IF EXISTS `used_code`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `used_code` (
  `c` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`c`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `used_code`
--

LOCK TABLES `used_code` WRITE;
/*!40000 ALTER TABLE `used_code` DISABLE KEYS */;
INSERT INTO `used_code` VALUES ('1'),('1234-5678-9123-4564'),('BDTI-WPF7-J3JX-5AH9'),('TPTI-0BE7-T6MD-KSGK'),('TQ2J-H6DS-F3MX-2N0S'),('XV8Q-YS0H-YU1F-FSGX'),('ZNIV-L3JB-UP63-GQLJ');
/*!40000 ALTER TABLE `used_code` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nickname` varchar(45) COLLATE utf8mb4_general_ci NOT NULL,
  `password` longtext COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (4,'tonda','rexBWM/nBLV2UdaJgLS8xg==.Qaqzadmw608XPf6tnc119LkslvWNQEHNU2VkjFjIMJo='),(5,'admin','ERlbFqIuE2PCFOmQVDXHKQ==./S57RkRLIhVL8pGYQGZ/Cq0h+rrNj1nhRWOoaDv3TVY='),(6,'Petr','pMS17WVyg1H3Hf1OJ3LFwg==.Cx3VujB29nMbZ9kWaDt6AJfVmUqVIJOEiuwnUadBp1M='),(7,'jakoubek','q1XT1aBNmUB+TIdaD7eqcQ==.mRF6zAB8MHn6lKgNOEnW2UFzZQBoiEU3buw5lsi4l4M='),(8,'tonda','1FqxF5v6TMx4F26eZRp/Ow==.mEKitLwaqSKZJ8mneuRJtANEFkoT7GeHoXuA2K4MFBc='),(9,'kuba','7uBvo0kvo4utTSFYVBYeEA==.zX3rsguE3hKj7AIP73cnIRjCz9Swhr5m6u3qaYSJTQQ='),(10,'Terezka','DzapckZXH0TGPMc2y0uqhA==.trwyHZpLFbLhOQ2mxWuGBgy/Tm8oYlQNwWc0T+E1Kq8='),(11,'dasd','46oG6O6nfBieyFlg657WWw==.BiY7tQkkD1f/ha0yR2DmWhYwj/H1L424GVLYzhx815Q='),(12,'dasd','TP0rikWDYSwP1t3RfEpWHg==.Vgt7ampdLXHpxpf2yE8pN06ZBqGMY9YZ7rA+enP3NCw=');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'rozpocet_tool'
--

--
-- Dumping routines for database 'rozpocet_tool'
--
SET @@SESSION.SQL_LOG_BIN = @MYSQLDUMP_TEMP_LOG_BIN;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-12 20:51:23
