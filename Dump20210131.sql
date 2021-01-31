CREATE DATABASE  IF NOT EXISTS `assignment` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `assignment`;
-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: assignment
-- ------------------------------------------------------
-- Server version	5.7.16-log

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

--
-- Table structure for table `tbl_meetup`
--

DROP TABLE IF EXISTS `tbl_meetup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_meetup` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `dateofbirth` datetime DEFAULT NULL,
  `profession` varchar(45) DEFAULT NULL,
  `locality` varchar(100) DEFAULT NULL,
  `noofguest` int(11) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `createdon` datetime DEFAULT NULL,
  `updatedon` datetime DEFAULT NULL,
  `isdeleted` bit(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_meetup`
--

LOCK TABLES `tbl_meetup` WRITE;
/*!40000 ALTER TABLE `tbl_meetup` DISABLE KEYS */;
INSERT INTO `tbl_meetup` VALUES (1,'Anand Sarate',28,'1992-06-24 00:00:00','developer','Borivali',2,'Mumbai,Maharashtra','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(2,'Anand Test1',28,'1992-06-24 00:00:00','interns','Borivali',1,'Mumbai,Maharashtra','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(3,'Test Anand',30,'1992-06-27 00:00:00','Test','Pune',2,'Pune','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary ''),(4,'test user',24,'1992-07-20 00:00:00','student','mumbai',2,'mumbai.maharashtra,mumbai.maharashtra,mumbai','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(5,'test anand',40,'1992-06-24 00:00:00','developer','pune',1,'mumbai','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(6,'test user1',23,'1992-04-20 00:00:00','Student','Mumbai',2,'Andheri (west), mumbai-400068','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(7,'test user2',23,'1992-04-20 00:00:00','Student','Mumbai',2,'Andheri (west), mumbai-400068','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(8,'test user3',23,'1992-04-20 00:00:00','Student','Mumbai',2,'Andheri (west), mumbai-400068','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(9,'test user4',23,'1992-04-20 00:00:00','Student','Pune',2,'Pune station , Pune-400068','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(10,'test user5',23,'1992-04-20 00:00:00','Student','Pune',2,'Pune station , Pune-400068','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(11,'test user6',23,'1992-04-21 00:00:00','Student','Pune',2,'Pune station , Pune-400068','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(12,'test user7',23,'1992-04-21 00:00:00','Student','Pune',2,'Pune station , Pune-400068','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(13,'test user8',23,'1992-04-21 00:00:00','Student','Pune',2,'Pune station , Pune-400068','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(14,'test user9',23,'1992-04-21 00:00:00','Student','Pune',2,'Pune station , Pune-400068','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(15,'test user10',23,'1992-04-22 00:00:00','Student','Mumbai',2,'Borivali (west), mumbai-400068','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(16,'test user11',23,'1992-04-22 00:00:00','Student','Mumbai',2,'Borivali (west), mumbai-400068','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(17,'test user12',23,'1992-04-22 00:00:00','Student','Mumbai',2,'Borivali (west), mumbai-400068','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(18,'test user13',23,'1992-04-22 00:00:00','Student','Mumbai',2,'Borivali (west), mumbai-400068','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(19,'test user14',30,'1992-06-15 00:00:00','Employed','Pune',2,'Swargate, pune -4111025','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(20,'test user15',30,'1992-06-15 00:00:00','Employed','Pune',2,'Swargate, pune -4111025','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(21,'test user16',30,'1992-06-15 00:00:00','Employed','Pune',2,'Swargate, pune -4111025','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(22,'test user17',30,'1992-06-15 00:00:00','Employed','Pune',2,'Swargate, pune -4111025','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(23,'test user18',30,'1992-06-15 00:00:00','Employed','Pune',2,'Swargate, pune -4111025','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(24,'test user19',30,'1992-06-15 00:00:00','Employed','Pune',2,'Swargate, pune -4111025','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(25,'test user20',30,'1992-06-15 00:00:00','Employed','Pune',2,'Swargate, pune -4111025','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(26,'test user21',30,'1992-08-24 00:00:00','Employed','Pune',2,'Swargate, pune -4111025','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(27,'test user22',30,'1992-08-24 00:00:00','Employed','Pune',2,'Swargate, pune -4111025','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(28,'test user23',30,'1992-08-24 00:00:00','Employed','Pune',2,'Swargate, pune -4111025','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(29,'test user24',30,'1992-08-24 00:00:00','Employed','Pune',2,'Swargate, pune -4111025','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(30,'test user25',30,'1992-08-24 00:00:00','Employed','Pune',2,'Swargate, pune -4111025','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(31,'test user26',30,'1992-08-24 00:00:00','Employed','Pune',2,'Swargate, pune -4111025','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(32,'test user27',30,'1992-08-24 00:00:00','Employed','Pune',2,'Swargate, pune -4111025','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(33,'test user28',30,'1992-08-24 00:00:00','Employed','Pune',2,'Swargate, pune -4111025','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(34,'test user29',30,'1987-03-14 00:00:00','Employed','Mumbai',2,'Dadar, mumbai-4000877','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(35,'test user30',30,'1987-03-14 00:00:00','Employed','Mumbai',2,'Dadar, mumbai-4000877','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(36,'test user31',32,'1987-03-14 00:00:00','Employed','Mumbai',2,'Dadar, mumbai-4000877','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(37,'test user32',32,'1987-03-14 00:00:00','Employed','Mumbai',2,'Dadar, mumbai-4000877','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(38,'test user33',32,'1987-03-14 00:00:00','Employed','Mumbai',2,'Dadar, mumbai-4000877','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(39,'test user34',32,'1987-03-14 00:00:00','Employed','Mumbai',2,'Dadar, mumbai-4000877','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(40,'test user35',32,'1987-03-14 00:00:00','Employed','Mumbai',2,'Dadar, mumbai-4000877','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(41,'test user36',32,'1987-03-14 00:00:00','Employed','Mumbai',2,'Dadar, mumbai-4000877','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(42,'test user37',32,'1987-03-14 00:00:00','Employed','Mumbai',2,'Dadar, mumbai-4000877','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(43,'test user38',32,'1987-03-14 00:00:00','Employed','Mumbai',2,'Dadar, mumbai-4000877','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(44,'test user39',32,'1987-03-14 00:00:00','Employed','Mumbai',2,'Dadar, mumbai-4000877','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(45,'test user40',32,'1987-03-14 00:00:00','Employed','Mumbai',2,'Dadar, mumbai-4000877','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(46,'test user41',32,'1987-03-14 00:00:00','Employed','Pune',2,'Shivaji Nagar, pune-478548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(47,'test user42',32,'1987-03-14 00:00:00','Employed','Pune',2,'Shivaji Nagar, pune-478548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(48,'test user43',28,'1991-01-01 00:00:00','Employed','Pune',2,'Shivaji Nagar, pune-478548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(49,'test user44',28,'1991-01-01 00:00:00','Employed','Pune',2,'Shivaji Nagar, pune-478548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(50,'test user45',28,'1991-01-01 00:00:00','Employed','Pune',2,'Shivaji Nagar, pune-478548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(51,'test user46',28,'1991-01-01 00:00:00','Employed','Pune',2,'Shivaji Nagar, pune-478548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(52,'test user47',28,'1991-01-01 00:00:00','Employed','Pune',2,'Shivaji Nagar, pune-478548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(53,'test user48',28,'1991-01-01 00:00:00','Employed','Pune',2,'Shivaji Nagar, pune-478548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(54,'test user49',28,'1991-01-01 00:00:00','Employed','Pune',2,'Shivaji Nagar, pune-478548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(55,'test user50',28,'1991-01-01 00:00:00','Employed','Pune',2,'Shivaji Nagar, pune-478548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(56,'test user51',28,'1991-01-01 00:00:00','Employed','Pune',2,'Shivaji Nagar, pune-478548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(57,'test user52',28,'1991-01-01 00:00:00','Employed','Pune',2,'Shivaji Nagar, pune-478548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(58,'test user53',28,'1998-04-07 00:00:00','Employed','Mumbai',2,'Andheri (East) , mumbai - 498548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(59,'test user54',28,'1998-04-07 00:00:00','Employed','Mumbai',2,'Andheri (East) , mumbai - 498548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(60,'test user55',28,'1998-04-07 00:00:00','Employed','Mumbai',2,'Andheri (East) , mumbai - 498548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(61,'test user56',27,'1998-04-07 00:00:00','Employed','Mumbai',2,'Andheri (East) , mumbai - 498548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0'),(62,'test user57',27,'1998-04-07 00:00:00','Employed','Mumbai',2,'Andheri (East) , mumbai - 498548','2021-01-31 00:00:00','2021-01-31 00:00:00',_binary '\0');
/*!40000 ALTER TABLE `tbl_meetup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'assignment'
--

--
-- Dumping routines for database 'assignment'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-01-31 23:49:03
