-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3307
-- Generation Time: Jan 01, 2022 at 02:20 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 7.3.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cachlycovid19`
--

-- --------------------------------------------------------

--
-- Table structure for table `cn_tc`
--

CREATE TABLE `cn_tc` (
  `MaCongNhan` varchar(5) COLLATE utf8_unicode_ci NOT NULL,
  `MaTrieuChung` varchar(5) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Table structure for table `congnhan`
--

CREATE TABLE `congnhan` (
  `MaCongNhan` varchar(5) COLLATE utf8_unicode_ci NOT NULL,
  `TenCongNhan` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `GioiTinh` tinyint(1) NOT NULL,
  `NamSinh` int(11) NOT NULL,
  `NuocVe` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `MaDiemCachLy` varchar(5) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `congnhan`
--

INSERT INTO `congnhan` (`MaCongNhan`, `TenCongNhan`, `GioiTinh`, `NamSinh`, `NuocVe`, `MaDiemCachLy`) VALUES
('CN01', 'Nguyễn Văn Hiếu', 1, 2001, 'Anh', 'DCL01'),
('CN02', 'Hồng Cúc', 0, 1995, 'Nhật', 'DCL01');

-- --------------------------------------------------------

--
-- Table structure for table `diemcachly`
--

CREATE TABLE `diemcachly` (
  `MaDiemCachLy` varchar(5) COLLATE utf8_unicode_ci NOT NULL,
  `TenDiemCachLy` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `DiaChi` varchar(150) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `diemcachly`
--

INSERT INTO `diemcachly` (`MaDiemCachLy`, `TenDiemCachLy`, `DiaChi`) VALUES
('DCL01', 'Biên Hòa', 'DC1'),
('DCL03', 'Dĩ An', 'DC3');

-- --------------------------------------------------------

--
-- Table structure for table `trieuchung`
--

CREATE TABLE `trieuchung` (
  `MaTrieuChung` varchar(5) COLLATE utf8_unicode_ci NOT NULL,
  `TenTrieuChung` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `trieuchung`
--

INSERT INTO `trieuchung` (`MaTrieuChung`, `TenTrieuChung`) VALUES
('TT01', 'Sốt'),
('TT02', 'Ho'),
('TT03', 'Khó thở');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cn_tc`
--
ALTER TABLE `cn_tc`
  ADD PRIMARY KEY (`MaCongNhan`,`MaTrieuChung`),
  ADD KEY `MaTrieuChung` (`MaTrieuChung`);

--
-- Indexes for table `congnhan`
--
ALTER TABLE `congnhan`
  ADD PRIMARY KEY (`MaCongNhan`),
  ADD KEY `MaDiemCachLy` (`MaDiemCachLy`);

--
-- Indexes for table `diemcachly`
--
ALTER TABLE `diemcachly`
  ADD PRIMARY KEY (`MaDiemCachLy`);

--
-- Indexes for table `trieuchung`
--
ALTER TABLE `trieuchung`
  ADD PRIMARY KEY (`MaTrieuChung`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cn_tc`
--
ALTER TABLE `cn_tc`
  ADD CONSTRAINT `cn_tc_ibfk_1` FOREIGN KEY (`MaCongNhan`) REFERENCES `congnhan` (`MaCongNhan`),
  ADD CONSTRAINT `cn_tc_ibfk_2` FOREIGN KEY (`MaTrieuChung`) REFERENCES `trieuchung` (`MaTrieuChung`);

--
-- Constraints for table `congnhan`
--
ALTER TABLE `congnhan`
  ADD CONSTRAINT `congnhan_ibfk_1` FOREIGN KEY (`MaDiemCachLy`) REFERENCES `diemcachly` (`MaDiemCachLy`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
