-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 07, 2019 at 05:56 AM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pages_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `pages`
--

CREATE TABLE `pages` (
  `PAGEID` int(20) UNSIGNED NOT NULL,
  `BUSINESSNAME` varchar(255) DEFAULT NULL,
  `TAGLINE` varchar(255) DEFAULT NULL,
  `TITLE` varchar(255) DEFAULT NULL,
  `SUBTITLE` varchar(255) DEFAULT NULL,
  `DESCRIPTION` mediumtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pages`
--

INSERT INTO `pages` (`PAGEID`, `BUSINESSNAME`, `TAGLINE`, `TITLE`, `SUBTITLE`, `DESCRIPTION`) VALUES
(3, 'Lovisha Boutique', 'Clothes', 'crop top', 'blue', 'blue tops'),
(4, 'Fila', 'shoes', 'winter boots', 'Geese feather', 'Warm insulated');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pages`
--
ALTER TABLE `pages`
  ADD PRIMARY KEY (`PAGEID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pages`
--
ALTER TABLE `pages`
  MODIFY `PAGEID` int(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
