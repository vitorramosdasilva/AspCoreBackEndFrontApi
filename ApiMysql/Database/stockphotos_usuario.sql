-- MySQL dump 10.13  Distrib 8.0.15, for Win64 (x86_64)
--
-- Host: localhost    Database: stockphotos
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `usuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(30) NOT NULL,
  `senha` varchar(30) NOT NULL,
  `nomeCompleto` varchar(50) NOT NULL,
  `dataNascimento` date NOT NULL,
  `usuarioContribuidor` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (3,'adbe1981@yahoo.com.br','12345','Vitor Ramos','2019-09-19',1),(5,'adbe1981@yahoo.com.br','12345','Vitor Ramos','2019-09-16',1),(6,'adbe1981@yahoo.com.br','12345','Vitor Ramos7','2019-09-19',0),(7,'adbe1981@yahoo.com.br','12345','Vitor Ramos8','2019-09-19',0),(8,'adbe1981@yahoo.com.br','12345','Vitor Ramos9','2019-09-19',1),(9,'adbe1981@yahoo.com.br','12345','Vitor Ramos','0001-01-01',0),(10,'adbe1981@yahoo.com.br','12345','Vitor Ramos','0001-01-01',0),(11,'adbe1981@yahoo.com.br','12345','Vitor Ramos11','1981-09-16',0),(12,'adbe1981@yahoo.com.br','12345','Vitor Ramos11','1981-09-20',0),(13,'adbe1981@yahoo.com.br','12345','Vitor Ramos12','1981-09-16',0),(14,'adbe1981@yahoo.com.br','12345','Vitor Ramos13','2019-01-01',0),(15,'adbe1981@yahoo.com.br','12345','Vitor Ramos','1981-09-25',1),(16,'AnaLucia@ymail.com.br','12345','Ana Lucia','1969-05-27',1),(17,'adbe1981@yahoo.com.br','12345','Vitor Ramos17','1981-09-16',1),(18,'adbe1981@yahoo.com.br','12345','Vitor Ramos18','1981-09-16',1),(19,'adbe1981@yahoo.com.br','12345','Vitor Ramos20','2019-09-16',1),(20,'adbe1981@yahoo.com.br','12345','TestedoJoao','1981-09-16',1),(21,'adbe1981@yahoo.com.br','12345','testeoutro4','1981-09-16',1),(22,'adbe1981@yahoo.com.br','12345','Vitor Ramos','2019-09-30',1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-09-30 22:34:53
