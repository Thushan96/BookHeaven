CREATE DATABASE  IF NOT EXISTS `heavendb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `heavendb`;
-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: localhost    Database: heavendb
-- ------------------------------------------------------
-- Server version	8.4.2

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
-- Table structure for table `books`
--

DROP TABLE IF EXISTS `books`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `books` (
  `Id` char(36) NOT NULL,
  `Title` longtext NOT NULL,
  `Author` longtext NOT NULL,
  `Genre` longtext NOT NULL,
  `ISBN` longtext NOT NULL,
  `Price` decimal(18,2) NOT NULL,
  `Quantity` int NOT NULL,
  `SupplierId` char(36) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Books_SupplierId` (`SupplierId`),
  CONSTRAINT `FK_Books_Suppliers_SupplierId` FOREIGN KEY (`SupplierId`) REFERENCES `suppliers` (`Id`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `books`
--

LOCK TABLES `books` WRITE;
/*!40000 ALTER TABLE `books` DISABLE KEYS */;
INSERT INTO `books` VALUES ('70c50b70-dfe1-40e6-b00f-8bc9c6d0d827','Village','K.F Bonn','Horror','123133',90.99,3,NULL),('7efdbbee-595a-47b2-ab31-235d957587b1','John','R.D Stewart','Fiction','123456789',19.99,6,NULL),('f0fdd66f-bdf8-479a-b278-8fc6dd85334c','World','A.R Rahaman','Thriller','123456789',19.99,13,'9c8f54e5-02f3-4722-8aa9-3519d2ed113a');
/*!40000 ALTER TABLE `books` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `Id` char(36) NOT NULL,
  `Name` longtext NOT NULL,
  `Email` longtext NOT NULL,
  `PhoneNumber` longtext NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES ('075c8078-2341-44fb-aea4-644faa94a377','Saman','saman@gmail.com','0123456789'),('21dec7d2-c870-4865-8af9-6b676a897c90','Shehan','shehanj@gmail.com','1234122345'),('2e223652-ed57-4a23-8f33-abb501464292','Bimal','bimal@gmail.com','02134569843'),('6b073872-b53a-4ec5-89a1-381a635847af','Sahan','sahan@gmail.com','1234567123'),('84e21ac8-54ab-4cf6-a1f4-b67931eb1a5e','Nirmal','Nirmal@gmail.com','1234567891');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderitem`
--

DROP TABLE IF EXISTS `orderitem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderitem` (
  `OrderId` char(36) NOT NULL,
  `BookId` char(36) NOT NULL,
  `Quantity` int NOT NULL,
  PRIMARY KEY (`BookId`,`OrderId`),
  KEY `IX_OrderItem_OrderId` (`OrderId`),
  CONSTRAINT `FK_OrderItem_Books_BookId` FOREIGN KEY (`BookId`) REFERENCES `books` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_OrderItem_Orders_OrderId` FOREIGN KEY (`OrderId`) REFERENCES `orders` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderitem`
--

LOCK TABLES `orderitem` WRITE;
/*!40000 ALTER TABLE `orderitem` DISABLE KEYS */;
INSERT INTO `orderitem` VALUES ('0adb5b63-27f7-4857-afde-cdfca1dd8b00','70c50b70-dfe1-40e6-b00f-8bc9c6d0d827',1),('142ff815-7739-4631-96af-0a8bdb4ec28c','70c50b70-dfe1-40e6-b00f-8bc9c6d0d827',3),('adbb4b9f-3643-4a12-9a4e-cd8655716047','70c50b70-dfe1-40e6-b00f-8bc9c6d0d827',2),('af38fecd-6ba4-474a-8bed-498a589f2360','70c50b70-dfe1-40e6-b00f-8bc9c6d0d827',1),('b2c89a6b-e311-45f7-991e-a6d506d99239','70c50b70-dfe1-40e6-b00f-8bc9c6d0d827',2),('ca2e9e17-1cd1-439c-9ba4-839caad6e493','70c50b70-dfe1-40e6-b00f-8bc9c6d0d827',1),('0adb5b63-27f7-4857-afde-cdfca1dd8b00','7efdbbee-595a-47b2-ab31-235d957587b1',1),('142ff815-7739-4631-96af-0a8bdb4ec28c','7efdbbee-595a-47b2-ab31-235d957587b1',2),('2cfeb5ed-de8e-48ac-8ddb-490bb7373f71','7efdbbee-595a-47b2-ab31-235d957587b1',1),('458adc69-5802-456c-af42-7f3f0e5ccff7','7efdbbee-595a-47b2-ab31-235d957587b1',1),('af38fecd-6ba4-474a-8bed-498a589f2360','7efdbbee-595a-47b2-ab31-235d957587b1',1),('b2c89a6b-e311-45f7-991e-a6d506d99239','7efdbbee-595a-47b2-ab31-235d957587b1',1),('c6613f0d-d4af-49b6-8b7b-e6efe0d47312','7efdbbee-595a-47b2-ab31-235d957587b1',2),('ca2e9e17-1cd1-439c-9ba4-839caad6e493','7efdbbee-595a-47b2-ab31-235d957587b1',1),('cac6c74c-1b61-4b60-843d-4fb329c3bbd3','7efdbbee-595a-47b2-ab31-235d957587b1',1),('e2c27ac2-40a1-4248-9590-4414a55bac66','7efdbbee-595a-47b2-ab31-235d957587b1',1),('e6d05330-7880-4e04-bddb-108f2ba54045','7efdbbee-595a-47b2-ab31-235d957587b1',1),('00c07328-82f4-46a4-b8b8-83aa07a421b0','f0fdd66f-bdf8-479a-b278-8fc6dd85334c',2),('153631ca-9de4-4edb-b02d-c4e9703ddd1c','f0fdd66f-bdf8-479a-b278-8fc6dd85334c',1),('744d026d-f4c5-43be-bd92-72dc37a096d9','f0fdd66f-bdf8-479a-b278-8fc6dd85334c',1),('af38fecd-6ba4-474a-8bed-498a589f2360','f0fdd66f-bdf8-479a-b278-8fc6dd85334c',1),('c6613f0d-d4af-49b6-8b7b-e6efe0d47312','f0fdd66f-bdf8-479a-b278-8fc6dd85334c',1),('e2c27ac2-40a1-4248-9590-4414a55bac66','f0fdd66f-bdf8-479a-b278-8fc6dd85334c',1),('e6d05330-7880-4e04-bddb-108f2ba54045','f0fdd66f-bdf8-479a-b278-8fc6dd85334c',1),('f641e4d0-1f63-4c2c-b396-74ba4dd39601','f0fdd66f-bdf8-479a-b278-8fc6dd85334c',1);
/*!40000 ALTER TABLE `orderitem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `Id` char(36) NOT NULL,
  `CustomerId` char(36) NOT NULL,
  `Status` longtext,
  `OrderDate` datetime(6) NOT NULL,
  `IsDelivery` tinyint(1) DEFAULT NULL,
  `Total` decimal(18,2) NOT NULL,
  `Discount` decimal(18,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`Id`),
  KEY `IX_Orders_CustomerId` (`CustomerId`),
  CONSTRAINT `FK_Orders_Customers_CustomerId` FOREIGN KEY (`CustomerId`) REFERENCES `customers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES ('00c07328-82f4-46a4-b8b8-83aa07a421b0','6b073872-b53a-4ec5-89a1-381a635847af','Completed','2025-03-12 14:52:34.747193',NULL,39.98,0.00),('0adb5b63-27f7-4857-afde-cdfca1dd8b00','075c8078-2341-44fb-aea4-644faa94a377','Completed','2025-03-12 14:51:51.998975',NULL,110.98,0.00),('142ff815-7739-4631-96af-0a8bdb4ec28c','21dec7d2-c870-4865-8af9-6b676a897c90','Completed','2025-03-06 16:22:18.920894',NULL,312.95,0.00),('153631ca-9de4-4edb-b02d-c4e9703ddd1c','84e21ac8-54ab-4cf6-a1f4-b67931eb1a5e','Completed','2025-03-06 14:46:14.233191',NULL,19.99,2.00),('2cfeb5ed-de8e-48ac-8ddb-490bb7373f71','2e223652-ed57-4a23-8f33-abb501464292','Completed','2025-03-09 15:23:23.958452',NULL,19.99,0.00),('458adc69-5802-456c-af42-7f3f0e5ccff7','21dec7d2-c870-4865-8af9-6b676a897c90','Completed','2025-03-06 16:26:14.287750',NULL,19.99,0.00),('744d026d-f4c5-43be-bd92-72dc37a096d9','21dec7d2-c870-4865-8af9-6b676a897c90','Completed','2025-03-09 15:23:56.934561',NULL,19.99,0.00),('adbb4b9f-3643-4a12-9a4e-cd8655716047','21dec7d2-c870-4865-8af9-6b676a897c90','Completed','2025-03-06 16:22:45.712564',NULL,181.98,0.00),('af38fecd-6ba4-474a-8bed-498a589f2360','21dec7d2-c870-4865-8af9-6b676a897c90','Completed','2025-03-06 16:24:14.770843',NULL,130.97,0.00),('b2c89a6b-e311-45f7-991e-a6d506d99239','6b073872-b53a-4ec5-89a1-381a635847af','Completed','2025-03-08 03:29:55.904982',NULL,201.97,0.00),('c6613f0d-d4af-49b6-8b7b-e6efe0d47312','21dec7d2-c870-4865-8af9-6b676a897c90','Completed','2025-03-06 16:52:52.899133',NULL,59.97,0.00),('ca2e9e17-1cd1-439c-9ba4-839caad6e493','84e21ac8-54ab-4cf6-a1f4-b67931eb1a5e','Completed','2025-03-06 14:38:46.632436',NULL,110.98,0.00),('cac6c74c-1b61-4b60-843d-4fb329c3bbd3','21dec7d2-c870-4865-8af9-6b676a897c90','Completed','2025-03-06 17:21:11.429435',NULL,18.99,1.00),('e2c27ac2-40a1-4248-9590-4414a55bac66','84e21ac8-54ab-4cf6-a1f4-b67931eb1a5e','Completed','2025-03-06 14:33:18.767595',NULL,39.98,0.00),('e6d05330-7880-4e04-bddb-108f2ba54045','2e223652-ed57-4a23-8f33-abb501464292','Completed','2025-03-10 13:39:41.359073',NULL,37.98,2.00),('f641e4d0-1f63-4c2c-b396-74ba4dd39601','84e21ac8-54ab-4cf6-a1f4-b67931eb1a5e','Completed','2025-03-06 14:48:57.523592',NULL,19.99,0.00);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplierorderitems`
--

DROP TABLE IF EXISTS `supplierorderitems`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplierorderitems` (
  `Id` char(36) NOT NULL,
  `SupplierOrderId` char(36) NOT NULL,
  `BookId` char(36) NOT NULL,
  `Quantity` int NOT NULL,
  `PricePerUnit` decimal(18,2) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_SupplierOrderItems_BookId` (`BookId`),
  KEY `IX_SupplierOrderItems_SupplierOrderId` (`SupplierOrderId`),
  CONSTRAINT `FK_SupplierOrderItems_Books_BookId` FOREIGN KEY (`BookId`) REFERENCES `books` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_SupplierOrderItems_SupplierOrders_SupplierOrderId` FOREIGN KEY (`SupplierOrderId`) REFERENCES `supplierorders` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplierorderitems`
--

LOCK TABLES `supplierorderitems` WRITE;
/*!40000 ALTER TABLE `supplierorderitems` DISABLE KEYS */;
/*!40000 ALTER TABLE `supplierorderitems` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplierorders`
--

DROP TABLE IF EXISTS `supplierorders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplierorders` (
  `Id` char(36) NOT NULL,
  `SupplierId` char(36) NOT NULL,
  `Status` longtext,
  `OrderDate` datetime(6) NOT NULL,
  `DeliveryDate` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_SupplierOrders_SupplierId` (`SupplierId`),
  CONSTRAINT `FK_SupplierOrders_Suppliers_SupplierId` FOREIGN KEY (`SupplierId`) REFERENCES `suppliers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplierorders`
--

LOCK TABLES `supplierorders` WRITE;
/*!40000 ALTER TABLE `supplierorders` DISABLE KEYS */;
/*!40000 ALTER TABLE `supplierorders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suppliers` (
  `Id` char(36) NOT NULL,
  `Name` longtext NOT NULL,
  `ContactInfo` longtext NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` VALUES ('9c8f54e5-02f3-4722-8aa9-3519d2ed113a','AD Suppliers','123232455');
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `Id` char(36) NOT NULL,
  `Username` longtext NOT NULL,
  `PasswordHash` longtext NOT NULL,
  `Role` int NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('2d80ee7f-3d59-486b-aae2-c3aa3129f41e','admin','$2a$11$jhVhDqHAPcYx/jnNcZtod.5Z9CH3hKdlOQ0jzkcfjAjY4hoPBKJC6',0),('ac64adb6-315c-4682-b369-2ff3ff2ab5e5','clerk2','1234',0),('bfd2c82b-3f63-4dc2-a37a-bb1911bf05be','clerk','$2a$11$4iql7hpKCCMDNJT8Iq6KQuXAEFikXg5FrR7toYSn3HHbTXuO/3pna',1);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-03-14 11:04:57
