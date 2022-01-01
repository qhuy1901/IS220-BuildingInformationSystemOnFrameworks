-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Oct 13, 2021 at 10:27 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.2.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `qlcs1`
--

-- --------------------------------------------------------

--
-- Table structure for table `album`
--

CREATE TABLE `album` (
  `MaAlBum` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `TenAlBum` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `MaCaSi` varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `album`
--

INSERT INTO `album` (`MaAlBum`, `TenAlBum`, `MaCaSi`) VALUES
('AB01', 'Chiều Mưa Trên Phố', 'CS01'),
('AB02', 'Chiều Buồn', 'CS01');

-- --------------------------------------------------------

--
-- Table structure for table `baihat`
--

CREATE TABLE `baihat` (
  `MaBaiHat` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `TenBaiHat` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TheLoai` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `MaAlBum` varchar(10) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `casi`
--

CREATE TABLE `casi` (
  `MaCaSi` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `TenCaSi` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `NgaySinh` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `casi`
--

INSERT INTO `casi` (`MaCaSi`, `TenCaSi`, `NgaySinh`) VALUES
('CS01', 'Nguyễn Phi Hùng', '2021-10-06'),
('CS02 ', 'Lam Trường', '2021-10-01'),
('CS03', 'Phi Nhung', '2021-10-02'),
('CS04', 'Phuong Thanh', '2021-10-03'),
('CS05', 'Đoan Trang', '2021-10-04'),
('CS06', 'Hiền Thục', '2021-10-05'),
('CS07', 'Đan trường', '2021-10-07'),
('CS08', 'Nguyễn Tùng', '2021-10-08'),
('CS10', 'Nam Anh', '2021-10-13'),
('CS11', 'Sơn Tùng', '2000-12-21'),
('CS12', 'Sơn Tùng', '2000-12-21');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `album`
--
ALTER TABLE `album`
  ADD PRIMARY KEY (`MaAlBum`),
  ADD KEY `fk_album_casi` (`MaCaSi`);

--
-- Indexes for table `baihat`
--
ALTER TABLE `baihat`
  ADD PRIMARY KEY (`MaBaiHat`),
  ADD KEY `fk_baihat_album` (`MaAlBum`);

--
-- Indexes for table `casi`
--
ALTER TABLE `casi`
  ADD PRIMARY KEY (`MaCaSi`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `album`
--
ALTER TABLE `album`
  ADD CONSTRAINT `fk_album_casi` FOREIGN KEY (`MaCaSi`) REFERENCES `casi` (`MaCaSi`);

--
-- Constraints for table `baihat`
--
ALTER TABLE `baihat`
  ADD CONSTRAINT `fk_baihat_album` FOREIGN KEY (`MaAlBum`) REFERENCES `album` (`MaAlBum`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
