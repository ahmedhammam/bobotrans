-- phpMyAdmin SQL Dump
-- version 3.4.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Apr 21, 2012 at 04:44 PM
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
  PRIMARY KEY (`id`)
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
  PRIMARY KEY (`id`)
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
  PRIMARY KEY (`id`)
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
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `kupcikarti`
--

CREATE TABLE IF NOT EXISTS `kupcikarti` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `imeIPrezime` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  `idKarte` int(11) NOT NULL,
  `tipKupca` int(11) NOT NULL,
  `dodatniPodaci` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `linije`
--

CREATE TABLE IF NOT EXISTS `linije` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

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
  PRIMARY KEY (`id`)
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
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `rasporedvoznji`
--

CREATE TABLE IF NOT EXISTS `rasporedvoznji` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idLinije` int(11) NOT NULL,
  `danUSedmici` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  `vrijeme` time NOT NULL,
  `potrebanBrojSjedista` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `stanice`
--

CREATE TABLE IF NOT EXISTS `stanice` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  `mjesto` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

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
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tipovikorisnika`
--

CREATE TABLE IF NOT EXISTS `tipovikorisnika` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tip` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=4 ;

--
-- Dumping data for table `tipovikorisnika`
--

INSERT INTO `tipovikorisnika` (`id`, `tip`) VALUES
(1, 'Radnik za šalterom'),
(2, 'Menadžer'),
(3, 'Serviser');

-- --------------------------------------------------------

--
-- Table structure for table `tipovikupacakarte`
--

CREATE TABLE IF NOT EXISTS `tipovikupacakarte` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(255) COLLATE utf8_slovenian_ci NOT NULL,
  `popust` decimal(10,0) NOT NULL,
  PRIMARY KEY (`id`)
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
  `idRasporedaVoznje` int(11) NOT NULL,
  `idAutobusa` int(11) NOT NULL,
  `vrijemePolaska` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `zakupiautobusa`
--

CREATE TABLE IF NOT EXISTS `zakupiautobusa` (
  `id` int(11) NOT NULL,
  `idAutobusa` int(11) NOT NULL,
  `cijena` decimal(10,0) NOT NULL,
  `pocetakZakupa` date NOT NULL,
  `krajZakupa` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_slovenian_ci;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
