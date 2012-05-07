-- phpMyAdmin SQL Dump
-- version 3.4.10.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: May 07, 2012 at 08:39 PM
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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=15 ;

--
-- Dumping data for table `autobusi`
--

INSERT INTO `autobusi` (`id`, `registracijskeTablice`, `istekRegistracije`, `brojSjedista`, `datumServisa`, `toalet`, `slobodan`, `klima`) VALUES
(1, '123-K-123', '2012-05-05', 49, '2012-05-03', 1, 0, 1),
(4, '234-K-319', '2012-10-07', 39, '2012-04-20', 0, 0, 0),
(5, '324-A-322', '2013-04-17', 69, '2012-04-11', 0, 0, 1),
(13, '159-M-753', '2013-05-05', 61, '2012-05-05', 0, 1, 1),
(14, '871-N-869', '2013-07-10', 45, '2012-05-06', 1, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `izvjestaji`
--

CREATE TABLE IF NOT EXISTS `izvjestaji` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `datum` date NOT NULL,
  `tekst` text COLLATE utf8_slovenian_ci NOT NULL,
  `idKreatora` int(11) NOT NULL,
  `idAutobusa` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idKreatora` (`idKreatora`),
  KEY `idAutobusa` (`idAutobusa`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=5 ;

--
-- Dumping data for table `izvjestaji`
--

INSERT INTO `izvjestaji` (`id`, `datum`, `tekst`, `idKreatora`, `idAutobusa`) VALUES
(1, '2012-04-26', 'lorem ipsum sid dolorem amet', 5, 4),
(2, '2012-04-30', 'lorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\nlorem ipsum sid dolorem amet\n', 5, 1),
(3, '2012-04-30', 'ijoijoijo', 5, 4),
(4, '2012-04-30', 'the quick brown fox', 5, 1);

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
  `vrijemeIDatumKupovine` datetime NOT NULL,
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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=32 ;

--
-- Dumping data for table `linije`
--

INSERT INTO `linije` (`id`, `naziv`) VALUES
(28, 'Banja Luka - Doboj'),
(31, 'Doboj - Banja Luka'),
(27, 'Doboj - Tuzla'),
(24, 'Kakanj - Tuzla'),
(29, 'Sarajevo - Kakanj');

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=151 ;

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
(130, 24, 12, 9, '2.5'),
(131, 27, 13, 12, '2.0'),
(132, 27, 13, 9, '3.0'),
(133, 27, 12, 9, '1.5'),
(134, 28, 14, 13, '5.0'),
(135, 29, 15, 2, '1.0'),
(136, 29, 15, 1, '3.0'),
(137, 29, 15, 3, '4.0'),
(138, 29, 15, 4, '5.0'),
(139, 29, 15, 5, '6.0'),
(140, 29, 2, 1, '2.5'),
(141, 29, 2, 3, '3.5'),
(142, 29, 2, 4, '4.5'),
(143, 29, 2, 5, '5.5'),
(144, 29, 1, 3, '1.5'),
(145, 29, 1, 4, '2.5'),
(146, 29, 1, 5, '3.4'),
(147, 29, 3, 4, '1.5'),
(148, 29, 3, 5, '2.6'),
(149, 29, 4, 5, '1.0'),
(150, 31, 13, 14, '5.0');

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=30 ;

--
-- Dumping data for table `linijerasporedvoznji`
--

INSERT INTO `linijerasporedvoznji` (`id`, `idLinije`, `idRasporedaVoznje`) VALUES
(15, 24, 21),
(16, 24, 22),
(21, 27, 27),
(22, 27, 28),
(23, 28, 29),
(24, 28, 30),
(25, 29, 31),
(26, 29, 32),
(27, 29, 33),
(28, 31, 34),
(29, 31, 35);

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=51 ;

--
-- Dumping data for table `linijevoznje`
--

INSERT INTO `linijevoznje` (`id`, `idLinije`, `idVoznje`) VALUES
(36, 24, 37),
(37, 24, 38),
(42, 27, 43),
(43, 27, 44),
(44, 28, 45),
(45, 28, 46),
(46, 29, 47),
(47, 29, 48),
(48, 29, 49),
(49, 31, 50),
(50, 31, 51);

-- --------------------------------------------------------

--
-- Table structure for table `poruke`
--

CREATE TABLE IF NOT EXISTS `poruke` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idPosiljaoca` int(11) NOT NULL,
  `idPrimaoca` int(11) NOT NULL,
  `vrijemeSlanja` datetime NOT NULL,
  `tekst` text COLLATE utf8_slovenian_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idPosiljaoca` (`idPosiljaoca`),
  KEY `idPrimaoca` (`idPrimaoca`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=18 ;

--
-- Dumping data for table `poruke`
--

INSERT INTO `poruke` (`id`, `idPosiljaoca`, `idPrimaoca`, `vrijemeSlanja`, `tekst`) VALUES
(2, 3, 5, '2012-04-02 00:00:00', 'lorem ipsum sid dolorem amet'),
(3, 1, 5, '2012-04-17 00:00:00', 'the quick brown fox jumps over the lazy dog'),
(7, 8, 3, '2012-05-04 18:43:00', 'Hello =)'),
(8, 8, 5, '2012-05-04 18:47:00', 'Popravi onaj autobus!'),
(15, 5, 1, '2012-05-05 01:56:00', 'Cao macko ja bih te cacko\n'),
(17, 5, 3, '2012-05-05 02:00:00', 'Cao macko ja bih te cacko\n');

-- --------------------------------------------------------

--
-- Table structure for table `rasporedvoznjeautobus`
--

CREATE TABLE IF NOT EXISTS `rasporedvoznjeautobus` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idRasporedaVoznje` int(11) NOT NULL,
  `idAutobusa` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `idRasporedaVoznje_2` (`idRasporedaVoznje`),
  KEY `idRasporedaVoznje` (`idRasporedaVoznje`),
  KEY `idAutobusa` (`idAutobusa`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=13 ;

--
-- Dumping data for table `rasporedvoznjeautobus`
--

INSERT INTO `rasporedvoznjeautobus` (`id`, `idRasporedaVoznje`, `idAutobusa`) VALUES
(1, 21, 1),
(2, 22, 4),
(3, 27, 5),
(4, 28, 5),
(5, 29, 5),
(6, 30, 5),
(7, 31, 5),
(8, 32, 1),
(9, 33, 1),
(10, 34, 5),
(12, 35, 5);

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=36 ;

--
-- Dumping data for table `rasporedvoznji`
--

INSERT INTO `rasporedvoznji` (`id`, `danUSedmici`, `sati`, `minute`, `potrebanBrojSjedista`) VALUES
(21, '1', 10, 0, 50),
(22, '5', 15, 30, 50),
(27, '2', 12, 10, 25),
(28, '5', 18, 30, 25),
(29, '3', 11, 10, 25),
(30, '7', 17, 30, 25),
(31, '6', 17, 43, 25),
(32, '4', 15, 40, 25),
(33, '2', 10, 20, 25),
(34, '3', 11, 50, 25),
(35, '7', 18, 10, 25);

-- --------------------------------------------------------

--
-- Table structure for table `stanice`
--

CREATE TABLE IF NOT EXISTS `stanice` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  `mjesto` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=16 ;

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
(13, 'Doboj', 'Doboj'),
(14, 'Glavna Stanica', 'Banja Luka'),
(15, 'Glavna stanica', 'Sarajevo');

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=136 ;

--
-- Dumping data for table `staniceuliniji`
--

INSERT INTO `staniceuliniji` (`id`, `idLinije`, `idStanice`, `trajanjeDoDolaska`, `trajanjeDoPolaska`) VALUES
(111, 24, 5, 0, 0),
(112, 24, 10, 30, 35),
(113, 24, 11, 60, 65),
(114, 24, 13, 80, 90),
(115, 24, 12, 110, 120),
(116, 24, 9, 130, 130),
(123, 27, 13, 0, 0),
(124, 27, 12, 30, 35),
(125, 27, 9, 50, 50),
(126, 28, 14, 0, 0),
(127, 28, 13, 30, 30),
(128, 29, 15, 0, 0),
(129, 29, 2, 15, 16),
(130, 29, 1, 30, 31),
(131, 29, 3, 40, 41),
(132, 29, 4, 60, 61),
(133, 29, 5, 70, 70),
(134, 31, 13, 0, 0),
(135, 31, 14, 30, 30);

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=52 ;

--
-- Dumping data for table `voznje`
--

INSERT INTO `voznje` (`id`, `idAutobusa`, `vrijemePolaska`, `sati`, `minute`) VALUES
(37, 1, '2012-05-05', 10, 0),
(38, 4, '2012-05-07', 15, 30),
(43, 5, '2012-06-10', 12, 10),
(44, 5, '2012-05-07', 18, 30),
(45, 5, '2012-05-10', 11, 10),
(46, 5, '2012-05-07', 17, 30),
(47, 5, '2012-05-10', 17, 43),
(48, 1, '2012-05-13', 15, 40),
(49, 1, '2012-05-16', 10, 20),
(50, 5, '2012-05-10', 11, 50),
(51, 5, '2012-05-07', 18, 10);

-- --------------------------------------------------------

--
-- Table structure for table `zakupiautobusa`
--

CREATE TABLE IF NOT EXISTS `zakupiautobusa` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `imeZakupca` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  `idAutobusa` int(11) NOT NULL,
  `cijena` decimal(10,0) NOT NULL,
  `pocetakZakupa` date NOT NULL,
  `krajZakupa` date NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idAutobusa` (`idAutobusa`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=5 ;

--
-- Dumping data for table `zakupiautobusa`
--

INSERT INTO `zakupiautobusa` (`id`, `imeZakupca`, `idAutobusa`, `cijena`, `pocetakZakupa`, `krajZakupa`) VALUES
(2, 'ETF Sarajevo', 13, '2000', '2012-05-01', '2012-05-15'),
(3, 'Druga gimnazija Sarajevo', 13, '5000', '2012-04-01', '2012-04-07'),
(4, 'htfdyt', 14, '5000', '2012-05-22', '2012-05-29');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `izvjestaji`
--
ALTER TABLE `izvjestaji`
  ADD CONSTRAINT `izvjestaji_ibfk_1` FOREIGN KEY (`idKreatora`) REFERENCES `korisnici` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `izvjestaji_ibfk_2` FOREIGN KEY (`idAutobusa`) REFERENCES `autobusi` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

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
-- Constraints for table `rasporedvoznjeautobus`
--
ALTER TABLE `rasporedvoznjeautobus`
  ADD CONSTRAINT `rasporedvoznjeautobus_ibfk_1` FOREIGN KEY (`idRasporedaVoznje`) REFERENCES `rasporedvoznji` (`id`),
  ADD CONSTRAINT `rasporedvoznjeautobus_ibfk_2` FOREIGN KEY (`idAutobusa`) REFERENCES `autobusi` (`id`);

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
