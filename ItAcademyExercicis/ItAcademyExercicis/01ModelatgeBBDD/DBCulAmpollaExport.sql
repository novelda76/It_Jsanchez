-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: cul_ampolla
-- ------------------------------------------------------
-- Server version	8.0.17

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
-- Table structure for table `brandglasses`
--

DROP TABLE IF EXISTS `brandglasses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `brandglasses` (
  `idBrandGlasses` int(11) NOT NULL AUTO_INCREMENT,
  `brandDescription` varchar(50) NOT NULL,
  `Provider_idProvider` int(11) NOT NULL,
  PRIMARY KEY (`idBrandGlasses`),
  UNIQUE KEY `idBrandGlasses_UNIQUE` (`idBrandGlasses`),
  KEY `fk_BrandGlasses_Provider1_idx` (`Provider_idProvider`),
  CONSTRAINT `fk_BrandGlasses_Provider1` FOREIGN KEY (`Provider_idProvider`) REFERENCES `provider` (`idProvider`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `brandglasses`
--

LOCK TABLES `brandglasses` WRITE;
/*!40000 ALTER TABLE `brandglasses` DISABLE KEYS */;
INSERT INTO `brandglasses` VALUES (1,'RayBon',1),(2,'Licosta',1),(3,'Cebe',2),(4,'Fila',3),(5,'Pepe',2);
/*!40000 ALTER TABLE `brandglasses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `colourglass`
--

DROP TABLE IF EXISTS `colourglass`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `colourglass` (
  `idcolourGlass` int(11) NOT NULL AUTO_INCREMENT,
  `colourDescription` varchar(50) NOT NULL,
  PRIMARY KEY (`idcolourGlass`),
  UNIQUE KEY `idcolourGlass_UNIQUE` (`idcolourGlass`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `colourglass`
--

LOCK TABLES `colourglass` WRITE;
/*!40000 ALTER TABLE `colourglass` DISABLE KEYS */;
INSERT INTO `colourglass` VALUES (1,'Verde Aviador'),(2,'Amarillo nocturno'),(3,'Azul nieve'),(4,'Plateado');
/*!40000 ALTER TABLE `colourglass` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `colourmount`
--

DROP TABLE IF EXISTS `colourmount`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `colourmount` (
  `idcolourMount` int(11) NOT NULL AUTO_INCREMENT,
  `colourDescription` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idcolourMount`),
  UNIQUE KEY `idcolourMount_UNIQUE` (`idcolourMount`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `colourmount`
--

LOCK TABLES `colourmount` WRITE;
/*!40000 ALTER TABLE `colourmount` DISABLE KEYS */;
INSERT INTO `colourmount` VALUES (1,'Plateado claro'),(2,'Plateado oscuro'),(3,'Blanco'),(4,'Azul cobalto'),(5,'Dorado rosa');
/*!40000 ALTER TABLE `colourmount` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `idCustomer` int(11) NOT NULL AUTO_INCREMENT,
  `customerName` varchar(50) NOT NULL,
  `customerSurname` varchar(50) NOT NULL,
  `customerAddress` varchar(100) NOT NULL,
  `customerCity` varchar(50) DEFAULT NULL,
  `customerPostalCode` varchar(5) DEFAULT NULL,
  `customerTelephone` varchar(15) NOT NULL,
  `eMailCustomer` varchar(45) NOT NULL,
  `registryData` date NOT NULL,
  `referenceBy` int(11) NOT NULL,
  PRIMARY KEY (`idCustomer`),
  UNIQUE KEY `idCustomer_UNIQUE` (`idCustomer`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'ClienteUno','Primero','Calle Cliente Uno, 1, 1º-1ª','CityOne','28001','666 44 33 22','clienteuno@gmail.com','2019-12-01',2),(2,'ClienteDos','Segundo','Calle Cliente Dos, 2, 2º2ª','CityTwo','28001','665 44 33 22','clientedos@gmail.com','2019-11-10',1),(3,'ClienteTres','Tercero','Calle Cliente Tres, 3, 3º-3ª','CityTree','28003','655 44 22 33','clientetres@gmail.com','2019-11-10',1);
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `idEmployee` int(11) NOT NULL AUTO_INCREMENT,
  `employeeName` varchar(50) NOT NULL,
  `employeeSurname` varchar(50) NOT NULL,
  `employeeAddress` varchar(200) NOT NULL,
  `employeeCity` varchar(100) DEFAULT NULL,
  `employeePostalCode` varchar(5) DEFAULT NULL,
  `employeeCountry` varchar(50) DEFAULT NULL,
  `employeeTelephone` varchar(15) NOT NULL,
  `employeeEmail` varchar(100) NOT NULL,
  PRIMARY KEY (`idEmployee`),
  UNIQUE KEY `idEmployee_UNIQUE` (`idEmployee`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,'EmployeeOne','Primero','Calle Employee One, 1, 1º-1ª','CityOne','28001','CountryOne','655443322','employee1@gmail.com'),(2,'EmployeeTwo','Segundo','Calle Employee dos, 2, 2º-2ª','CityTwo','28002','CountryTwo','655443322','employee2@gmail.com'),(3,'EmployeeTree','Tercero','Calle Employee tres, 3, 3º-3ª','CityTree','28002','CountryOne','654334422','employee2@gmail.com'),(4,'EmployeeFour','Cuarto','Calle Employee cuatro','CityFour','28004','CountryTwo','123223344','employee4@gmail.com');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `glasses`
--

DROP TABLE IF EXISTS `glasses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `glasses` (
  `idGlasses` int(11) NOT NULL AUTO_INCREMENT,
  `leftGraduation` double(3,2) DEFAULT NULL,
  `rightGraduation` double(3,2) DEFAULT NULL,
  `priceGlasses` double(7,2) NOT NULL,
  `BrandGlasses_idBrandGlasses` int(11) NOT NULL,
  `MountTypes_idMountTypes` int(11) NOT NULL,
  `colourMount_idcolourMount` int(11) NOT NULL,
  `colourGlass_idcolourGlass` int(11) NOT NULL,
  `colourGlass_idcolourGlass1` int(11) NOT NULL,
  PRIMARY KEY (`idGlasses`),
  UNIQUE KEY `idGlasses_UNIQUE` (`idGlasses`),
  KEY `fk_Glasses_BrandGlasses_idx` (`BrandGlasses_idBrandGlasses`),
  KEY `fk_Glasses_MountTypes1_idx` (`MountTypes_idMountTypes`),
  KEY `fk_Glasses_colourMount1_idx` (`colourMount_idcolourMount`),
  KEY `fk_Glasses_colourGlass1_idx` (`colourGlass_idcolourGlass`),
  KEY `fk_Glasses_colourGlass2_idx` (`colourGlass_idcolourGlass1`),
  CONSTRAINT `fk_Glasses_BrandGlasses` FOREIGN KEY (`BrandGlasses_idBrandGlasses`) REFERENCES `brandglasses` (`idBrandGlasses`),
  CONSTRAINT `fk_Glasses_MountTypes1` FOREIGN KEY (`MountTypes_idMountTypes`) REFERENCES `mounttypes` (`idMountTypes`),
  CONSTRAINT `fk_Glasses_colourGlass1` FOREIGN KEY (`colourGlass_idcolourGlass`) REFERENCES `colourglass` (`idcolourGlass`),
  CONSTRAINT `fk_Glasses_colourGlass2` FOREIGN KEY (`colourGlass_idcolourGlass1`) REFERENCES `colourglass` (`idcolourGlass`),
  CONSTRAINT `fk_Glasses_colourMount1` FOREIGN KEY (`colourMount_idcolourMount`) REFERENCES `colourmount` (`idcolourMount`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `glasses`
--

LOCK TABLES `glasses` WRITE;
/*!40000 ALTER TABLE `glasses` DISABLE KEYS */;
INSERT INTO `glasses` VALUES (1,0.30,0.50,60.10,1,1,1,1,1),(2,0.30,0.15,99.10,4,2,1,3,3),(3,1.00,1.20,105.30,1,1,3,3,3);
/*!40000 ALTER TABLE `glasses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mounttypes`
--

DROP TABLE IF EXISTS `mounttypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mounttypes` (
  `idMountTypes` int(11) NOT NULL AUTO_INCREMENT,
  `descryptionMount` varchar(50) NOT NULL,
  PRIMARY KEY (`idMountTypes`),
  UNIQUE KEY `idMountTypes_UNIQUE` (`idMountTypes`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mounttypes`
--

LOCK TABLES `mounttypes` WRITE;
/*!40000 ALTER TABLE `mounttypes` DISABLE KEYS */;
INSERT INTO `mounttypes` VALUES (1,'Montura al aire aluminio'),(2,'Montura al aire titanio'),(3,'Montura metálica'),(4,'Montura pasta negra'),(5,'Montura flotante');
/*!40000 ALTER TABLE `mounttypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `provider`
--

DROP TABLE IF EXISTS `provider`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `provider` (
  `idProvider` int(11) NOT NULL AUTO_INCREMENT,
  `nameProvider` varchar(50) NOT NULL,
  `nifProvider` varchar(9) NOT NULL,
  `addressProvider` varchar(200) NOT NULL,
  `cityProvider` varchar(50) NOT NULL,
  `postalCodeProvider` varchar(5) NOT NULL,
  `countryProvider` varchar(50) NOT NULL,
  `telephoneProvider` varchar(15) NOT NULL,
  `faxProvider` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`idProvider`),
  UNIQUE KEY `idProvider_UNIQUE` (`idProvider`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `provider`
--

LOCK TABLES `provider` WRITE;
/*!40000 ALTER TABLE `provider` DISABLE KEYS */;
INSERT INTO `provider` VALUES (1,'ProveedorPrimero','123456789','Calle Proveedor Uno, 10, 1º-1ª','Ciudad Primera','28001','España','911234567',NULL),(2,'ProveedorSegundo','234567890','Calle Proveedor DOS, 20, 2º-2ª','Ciudad Segunda','08002','Cataluña','931234567','932212344'),(3,'ProveedorTercero','345678901','Calle Proveedor TRES, 30 3º-3ª','Ciudad Tercera','28002','España','912345678',NULL);
/*!40000 ALTER TABLE `provider` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sale`
--

DROP TABLE IF EXISTS `sale`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sale` (
  `idSale` int(11) NOT NULL AUTO_INCREMENT,
  `dateSale` date NOT NULL,
  `Employee_idEmployee` int(11) NOT NULL,
  `Customer_idCustomer` int(11) NOT NULL,
  `Glasses_idGlasses` int(11) NOT NULL,
  PRIMARY KEY (`idSale`),
  UNIQUE KEY `idSale_UNIQUE` (`idSale`),
  KEY `fk_Sale_Employee1_idx` (`Employee_idEmployee`),
  KEY `fk_Sale_Customer1_idx` (`Customer_idCustomer`),
  KEY `fk_Sale_Glasses1_idx` (`Glasses_idGlasses`),
  CONSTRAINT `fk_Sale_Customer1` FOREIGN KEY (`Customer_idCustomer`) REFERENCES `customer` (`idCustomer`),
  CONSTRAINT `fk_Sale_Employee1` FOREIGN KEY (`Employee_idEmployee`) REFERENCES `employee` (`idEmployee`),
  CONSTRAINT `fk_Sale_Glasses1` FOREIGN KEY (`Glasses_idGlasses`) REFERENCES `glasses` (`idGlasses`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sale`
--

LOCK TABLES `sale` WRITE;
/*!40000 ALTER TABLE `sale` DISABLE KEYS */;
INSERT INTO `sale` VALUES (1,'2019-09-26',4,2,1),(2,'2019-09-19',4,2,1),(3,'2019-09-24',2,3,2);
/*!40000 ALTER TABLE `sale` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-09-26 12:13:13
