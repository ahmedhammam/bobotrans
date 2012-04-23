-- phpMyAdmin SQL Dump
-- version 3.4.10.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Apr 23, 2012 at 10:34 PM
-- Server version: 5.5.20
-- PHP Version: 5.3.10

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `bobotrans`
--
CREATE DATABASE `bobotrans` DEFAULT CHARACTER SET utf8 COLLATE utf8_slovenian_ci;
USE `bobotrans`;

-- --------------------------------------------------------

--
-- Table structure for table `autobusi`
--

CREATE TABLE IF NOT EXISTS `autobusi` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `registracijskeTablice` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  `istekRegistracije` date NOT NULL,
  `brojSjedista` int(11) NOT NULL,
  `datumServisa` date NOT NULL,
  `toalet` tinyint(1) NOT NULL,
  `slobodan` tinyint(1) NOT NULL,
  `klima` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `registracijskeTablice` (`registracijskeTablice`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `izvjestaji`
--

CREATE TABLE IF NOT EXISTS `izvjestaji` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `datum` date NOT NULL,
  `tekst` text COLLATE utf8_slovenian_ci NOT NULL,
  `idKreatora` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idKreatora` (`idKreatora`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `karte`
--

CREATE TABLE IF NOT EXISTS `karte` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idVoznje` int(11) NOT NULL,
  `idPocetneStanice` int(11) NOT NULL,
  `idKrajnjeStanice` int(11) NOT NULL,
  `idSjedista` int(11) NOT NULL,
  `cijena` decimal(10,0) NOT NULL,
  `idKupca` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idVoznje` (`idVoznje`),
  KEY `idPocetneStanice` (`idPocetneStanice`),
  KEY `idKrajnjeStanice` (`idKrajnjeStanice`),
  KEY `idKupca` (`idKupca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `korisnici`
--

CREATE TABLE IF NOT EXISTS `korisnici` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `imeIPrezime` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  `tip` int(11) NOT NULL,
  `username` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  `lozinka` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username` (`username`),
  KEY `tip` (`tip`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=10 ;

--
-- Dumping data for table `korisnici`
--

INSERT INTO `korisnici` (`id`, `imeIPrezime`, `tip`, `username`, `lozinka`) VALUES
(1, 'Marina Miličević', 1, 'mmarina', 'mmarina'),
(3, 'Dženisa Husić', 2, 'dzhusic', 'dzhusic'),
(5, 'Adnan Ademović', 3, 'aademovic', 'aademovic'),
(8, 'Amer Mešanovic', 2, 'amesanovic', 'nekipass');

-- --------------------------------------------------------

--
-- Table structure for table `kupcikarti`
--

CREATE TABLE IF NOT EXISTS `kupcikarti` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `imeIPrezime` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  `tipKupca` int(11) NOT NULL,
  `dodatniPodaci` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `tipKupca` (`tipKupca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `linije`
--

CREATE TABLE IF NOT EXISTS `linije` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `naziv` (`naziv`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=2 ;

--
-- Dumping data for table `linije`
--

INSERT INTO `linije` (`id`, `naziv`) VALUES
(1, 'Sarajevo - Kakanj');

-- --------------------------------------------------------

--
-- Table structure for table `linijecijene`
--

CREATE TABLE IF NOT EXISTS `linijecijene` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idLinije` int(11) NOT NULL,
  `idPrveStanice` int(11) NOT NULL,
  `idDrugeStanice` int(11) NOT NULL,
  `cijena` decimal(10,0) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idLinije` (`idLinije`),
  KEY `idPrveStanice` (`idPrveStanice`),
  KEY `idDrugeStanice` (`idDrugeStanice`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `linijerasporedvoznji`
--

CREATE TABLE IF NOT EXISTS `linijerasporedvoznji` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idLinije` int(11) NOT NULL,
  `idRasporedaVoznje` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `idRasporedaVoznje_2` (`idRasporedaVoznje`),
  KEY `idLinije` (`idLinije`),
  KEY `idRasporedaVoznje` (`idRasporedaVoznje`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `linijevoznje`
--

CREATE TABLE IF NOT EXISTS `linijevoznje` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idLinije` int(11) NOT NULL,
  `idVoznje` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `idVoznje_2` (`idVoznje`),
  KEY `idLinije` (`idLinije`),
  KEY `idVoznje` (`idVoznje`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `poruke`
--

CREATE TABLE IF NOT EXISTS `poruke` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idPosiljaoca` int(11) NOT NULL,
  `idPrimaoca` int(11) NOT NULL,
  `vrijemeSlanja` date NOT NULL,
  `tekst` text COLLATE utf8_slovenian_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idPosiljaoca` (`idPosiljaoca`),
  KEY `idPrimaoca` (`idPrimaoca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `rasporedvoznji`
--

CREATE TABLE IF NOT EXISTS `rasporedvoznji` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `danUSedmici` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  `sati` int(11) NOT NULL,
  `minute` int(11) NOT NULL,
  `potrebanBrojSjedista` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=7 ;

--
-- Dumping data for table `rasporedvoznji`
--

INSERT INTO `rasporedvoznji` (`id`, `danUSedmici`, `sati`, `minute`, `potrebanBrojSjedista`) VALUES
(2, 'Ponedjeljak', 13, 25, 50),
(5, 'Utorak', 15, 40, 40),
(6, 'petak', 18, 55, 20);

-- --------------------------------------------------------

--
-- Table structure for table `stanice`
--

CREATE TABLE IF NOT EXISTS `stanice` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  `mjesto` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=6 ;

--
-- Dumping data for table `stanice`
--

INSERT INTO `stanice` (`id`, `naziv`, `mjesto`) VALUES
(1, 'Podlugovi', 'Podlugovi'),
(2, 'Reljevo', 'Reljevo'),
(3, 'Visoko', 'Visoko'),
(4, 'Dobrinje', 'Dobrinje'),
(5, 'Kakanj', 'Kakanj');

-- --------------------------------------------------------

--
-- Table structure for table `staniceuliniji`
--

CREATE TABLE IF NOT EXISTS `staniceuliniji` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idLinije` int(11) NOT NULL,
  `idStanice` int(11) NOT NULL,
  `trajanjeDoDolaska` int(11) NOT NULL,
  `trajanjeDoPolaska` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idLinije` (`idLinije`),
  KEY `idStanice` (`idStanice`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=6 ;

--
-- Dumping data for table `staniceuliniji`
--

INSERT INTO `staniceuliniji` (`id`, `idLinije`, `idStanice`, `trajanjeDoDolaska`, `trajanjeDoPolaska`) VALUES
(1, 1, 2, 15, 16),
(2, 1, 1, 30, 31),
(3, 1, 3, 40, 45),
(4, 1, 4, 50, 51),
(5, 1, 5, 70, 70);

-- --------------------------------------------------------

--
-- Table structure for table `tipovikorisnika`
--

CREATE TABLE IF NOT EXISTS `tipovikorisnika` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tip` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `tip` (`tip`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=4 ;

--
-- Dumping data for table `tipovikorisnika`
--

INSERT INTO `tipovikorisnika` (`id`, `tip`) VALUES
(2, 'Menadžer'),
(1, 'Radnik za šalterom'),
(3, 'Serviser');

-- --------------------------------------------------------

--
-- Table structure for table `tipovikupacakarte`
--

CREATE TABLE IF NOT EXISTS `tipovikupacakarte` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  `popust` decimal(10,0) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `naziv` (`naziv`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=4 ;

--
-- Dumping data for table `tipovikupacakarte`
--

INSERT INTO `tipovikupacakarte` (`id`, `naziv`, `popust`) VALUES
(1, 'Bez popusta', '0'),
(2, 'Student', '10'),
(3, 'Penzioner', '20');

-- --------------------------------------------------------

--
-- Table structure for table `voznje`
--

CREATE TABLE IF NOT EXISTS `voznje` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idAutobusa` int(11) NOT NULL,
  `vrijemePolaska` date NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idAutobusa` (`idAutobusa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `zakupiautobusa`
--

CREATE TABLE IF NOT EXISTS `zakupiautobusa` (
  `id` int(11) NOT NULL,
  `imeZakupca` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  `idAutobusa` int(11) NOT NULL,
  `cijena` decimal(10,0) NOT NULL,
  `pocetakZakupa` date NOT NULL,
  `krajZakupa` date NOT NULL,
  KEY `idAutobusa` (`idAutobusa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `izvjestaji`
--
ALTER TABLE `izvjestaji`
  ADD CONSTRAINT `izvjestaji_ibfk_1` FOREIGN KEY (`idKreatora`) REFERENCES `korisnici` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `karte`
--
ALTER TABLE `karte`
  ADD CONSTRAINT `karte_ibfk_2` FOREIGN KEY (`idPocetneStanice`) REFERENCES `stanice` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `karte_ibfk_3` FOREIGN KEY (`idKrajnjeStanice`) REFERENCES `stanice` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `karte_ibfk_4` FOREIGN KEY (`idKupca`) REFERENCES `kupcikarti` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `karte_ibfk_5` FOREIGN KEY (`idVoznje`) REFERENCES `voznje` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `korisnici`
--
ALTER TABLE `korisnici`
  ADD CONSTRAINT `korisnici_ibfk_1` FOREIGN KEY (`tip`) REFERENCES `tipovikorisnika` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `kupcikarti`
--
ALTER TABLE `kupcikarti`
  ADD CONSTRAINT `kupcikarti_ibfk_1` FOREIGN KEY (`tipKupca`) REFERENCES `tipovikupacakarte` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `linijecijene`
--
ALTER TABLE `linijecijene`
  ADD CONSTRAINT `linijecijene_ibfk_1` FOREIGN KEY (`idLinije`) REFERENCES `linije` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `linijecijene_ibfk_2` FOREIGN KEY (`idPrveStanice`) REFERENCES `stanice` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `linijecijene_ibfk_3` FOREIGN KEY (`idDrugeStanice`) REFERENCES `stanice` (`id`) ON UPDATE CASCADE;

--
-- Constraints for table `linijerasporedvoznji`
--
ALTER TABLE `linijerasporedvoznji`
  ADD CONSTRAINT `linijerasporedvoznji_ibfk_2` FOREIGN KEY (`idRasporedaVoznje`) REFERENCES `rasporedvoznji` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `linijerasporedvoznji_ibfk_1` FOREIGN KEY (`idLinije`) REFERENCES `linije` (`id`) ON UPDATE CASCADE;

--
-- Constraints for table `linijevoznje`
--
ALTER TABLE `linijevoznje`
  ADD CONSTRAINT `linijevoznje_ibfk_2` FOREIGN KEY (`idVoznje`) REFERENCES `voznje` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `linijevoznje_ibfk_3` FOREIGN KEY (`idLinije`) REFERENCES `linije` (`id`) ON UPDATE CASCADE;

--
-- Constraints for table `poruke`
--
ALTER TABLE `poruke`
  ADD CONSTRAINT `poruke_ibfk_1` FOREIGN KEY (`idPosiljaoca`) REFERENCES `korisnici` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `poruke_ibfk_2` FOREIGN KEY (`idPrimaoca`) REFERENCES `korisnici` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `staniceuliniji`
--
ALTER TABLE `staniceuliniji`
  ADD CONSTRAINT `staniceuliniji_ibfk_1` FOREIGN KEY (`idLinije`) REFERENCES `linije` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `staniceuliniji_ibfk_2` FOREIGN KEY (`idStanice`) REFERENCES `stanice` (`id`) ON UPDATE CASCADE;

--
-- Constraints for table `voznje`
--
ALTER TABLE `voznje`
  ADD CONSTRAINT `voznje_ibfk_1` FOREIGN KEY (`idAutobusa`) REFERENCES `autobusi` (`id`) ON UPDATE CASCADE;

--
-- Constraints for table `zakupiautobusa`
--
ALTER TABLE `zakupiautobusa`
  ADD CONSTRAINT `zakupiautobusa_ibfk_1` FOREIGN KEY (`idAutobusa`) REFERENCES `autobusi` (`id`) ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
