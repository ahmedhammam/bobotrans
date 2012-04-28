-- phpMyAdmin SQL Dump
-- version 3.4.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Apr 28, 2012 at 10:26 PM
-- Server version: 5.5.20
-- PHP Version: 5.3.9

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=5 ;

--
-- Dumping data for table `autobusi`
--

INSERT INTO `autobusi` (`id`, `registracijskeTablice`, `istekRegistracije`, `brojSjedista`, `datumServisa`, `toalet`, `slobodan`, `klima`) VALUES
(1, '123-K-456', '2012-05-05', 50, '2012-04-04', 1, 1, 1),
(4, '234-K-317', '2012-10-07', 40, '2012-04-20', 0, 1, 0);

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
  `cijena` decimal(10,2) NOT NULL,
  `idKupca` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idVoznje` (`idVoznje`),
  KEY `idPocetneStanice` (`idPocetneStanice`),
  KEY `idKrajnjeStanice` (`idKrajnjeStanice`),
  KEY `idKupca` (`idKupca`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=51 ;

--
-- Dumping data for table `karte`
--

INSERT INTO `karte` (`id`, `idVoznje`, `idPocetneStanice`, `idKrajnjeStanice`, `idSjedista`, `cijena`, `idKupca`) VALUES
(26, 37, 1, 2, 30, '10.00', 11),
(27, 37, 1, 2, 40, '20.00', 11),
(28, 37, 1, 2, 50, '30.00', 11),
(29, 37, 1, 2, 60, '40.00', 11),
(30, 37, 1, 2, 70, '50.00', 11),
(31, 37, 1, 2, 30, '11.00', 12),
(32, 37, 1, 2, 40, '12.00', 12),
(33, 37, 1, 2, 50, '13.00', 12),
(34, 37, 1, 2, 60, '14.00', 12),
(35, 37, 1, 2, 70, '15.00', 12),
(36, 38, 5, 9, 30, '11.00', 13),
(37, 38, 5, 9, 40, '12.00', 13),
(38, 38, 5, 9, 50, '13.00', 13),
(39, 38, 5, 9, 60, '14.00', 13),
(40, 38, 5, 9, 70, '15.00', 13),
(46, 38, 5, 9, 31, '11.20', 15),
(47, 38, 5, 9, 41, '12.20', 15),
(48, 38, 5, 9, 51, '13.20', 15),
(49, 38, 5, 9, 61, '14.20', 15),
(50, 38, 5, 9, 71, '15.20', 15);

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=9 ;

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
  PRIMARY KEY (`id`),
  KEY `tipKupca` (`tipKupca`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=16 ;

--
-- Dumping data for table `kupcikarti`
--

INSERT INTO `kupcikarti` (`id`, `imeIPrezime`, `tipKupca`) VALUES
(11, 'Amer Mesan', 1),
(12, 'Marina Mili', 3),
(13, 'Dzenisa BLA', 2),
(15, 'Dzenisa BLAdsad', 2);

-- --------------------------------------------------------

--
-- Table structure for table `linije`
--

CREATE TABLE IF NOT EXISTS `linije` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `naziv` (`naziv`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=26 ;

--
-- Dumping data for table `linije`
--

INSERT INTO `linije` (`id`, `naziv`) VALUES
(24, 'Kakanj - Tuzla');

-- --------------------------------------------------------

--
-- Table structure for table `linijecijene`
--

CREATE TABLE IF NOT EXISTS `linijecijene` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idLinije` int(11) NOT NULL,
  `idPrveStanice` int(11) NOT NULL,
  `idDrugeStanice` int(11) NOT NULL,
  `cijena` decimal(10,1) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idLinije` (`idLinije`),
  KEY `idPrveStanice` (`idPrveStanice`),
  KEY `idDrugeStanice` (`idDrugeStanice`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=131 ;

--
-- Dumping data for table `linijecijene`
--

INSERT INTO `linijecijene` (`id`, `idLinije`, `idPrveStanice`, `idDrugeStanice`, `cijena`) VALUES
(116, 24, 5, 10, '2.0'),
(117, 24, 5, 11, '5.0'),
(118, 24, 5, 13, '10.0'),
(119, 24, 5, 12, '13.0'),
(120, 24, 5, 9, '15.0'),
(121, 24, 10, 11, '3.5'),
(122, 24, 10, 13, '8.5'),
(123, 24, 10, 12, '11.5'),
(124, 24, 10, 9, '13.5'),
(125, 24, 11, 13, '5.5'),
(126, 24, 11, 12, '9.0'),
(127, 24, 11, 9, '11.0'),
(128, 24, 13, 12, '4.0'),
(129, 24, 13, 9, '5.5'),
(130, 24, 12, 9, '2.5');

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=17 ;

--
-- Dumping data for table `linijerasporedvoznji`
--

INSERT INTO `linijerasporedvoznji` (`id`, `idLinije`, `idRasporedaVoznje`) VALUES
(15, 24, 21),
(16, 24, 22);

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=38 ;

--
-- Dumping data for table `linijevoznje`
--

INSERT INTO `linijevoznje` (`id`, `idLinije`, `idVoznje`) VALUES
(36, 24, 37),
(37, 24, 38);

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=23 ;

--
-- Dumping data for table `rasporedvoznji`
--

INSERT INTO `rasporedvoznji` (`id`, `danUSedmici`, `sati`, `minute`, `potrebanBrojSjedista`) VALUES
(21, '1', 10, 0, 50),
(22, '5', 15, 30, 50);

-- --------------------------------------------------------

--
-- Table structure for table `stanice`
--

CREATE TABLE IF NOT EXISTS `stanice` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  `mjesto` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=14 ;

--
-- Dumping data for table `stanice`
--

INSERT INTO `stanice` (`id`, `naziv`, `mjesto`) VALUES
(1, 'Podlugovi', 'Podlugovi'),
(2, 'Reljevo', 'Reljevo'),
(3, 'Visoko', 'Visoko'),
(4, 'Dobrinje', 'Dobrinje'),
(5, 'Kakanj', 'Kakanj'),
(9, 'Tuzla', 'Tuzla'),
(10, 'Zenica', 'Zenica'),
(11, 'Banovic', 'Banovici'),
(12, 'Lukavac', 'Lukavac'),
(13, 'Doboj', 'Doboj');

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=117 ;

--
-- Dumping data for table `staniceuliniji`
--

INSERT INTO `staniceuliniji` (`id`, `idLinije`, `idStanice`, `trajanjeDoDolaska`, `trajanjeDoPolaska`) VALUES
(111, 24, 5, 0, 0),
(112, 24, 10, 30, 35),
(113, 24, 11, 60, 65),
(114, 24, 13, 80, 90),
(115, 24, 12, 110, 120),
(116, 24, 9, 130, 130);

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
  `sati` int(11) NOT NULL,
  `minute` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idAutobusa` (`idAutobusa`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=39 ;

--
-- Dumping data for table `voznje`
--

INSERT INTO `voznje` (`id`, `idAutobusa`, `vrijemePolaska`, `sati`, `minute`) VALUES
(37, 1, '2012-05-05', 10, 0),
(38, 4, '2012-05-07', 15, 30);

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
  ADD CONSTRAINT `linijerasporedvoznji_ibfk_1` FOREIGN KEY (`idLinije`) REFERENCES `linije` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `linijerasporedvoznji_ibfk_2` FOREIGN KEY (`idRasporedaVoznje`) REFERENCES `rasporedvoznji` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

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
