-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Jun 01, 2020 at 05:39 AM
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
-- Database: `qlsv`
--

-- --------------------------------------------------------

--
-- Table structure for table `BOMON`
--

CREATE TABLE `BOMON` (
  `MaBoMon` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `TenBoMon` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `MaKhoa` varchar(40) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `BOMON`
--

INSERT INTO `BOMON` (`MaBoMon`, `TenBoMon`, `MaKhoa`) VALUES
('MBM01', 'Hệ Thống Thông Tin Quản Lý', 'MK01'),
('MBM02', 'Hệ Thống Thông Tin Thông Minh', 'MK01'),
('MBM03', 'Thương Mại Điện Tử', 'MK01'),
('BM05', 'BM mới ', 'MK01');

-- --------------------------------------------------------

--
-- Table structure for table `KHOA`
--

CREATE TABLE `KHOA` (
  `MaKhoa` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `TenKhoa` varchar(40) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `KHOA`
--

INSERT INTO `KHOA` (`MaKhoa`, `TenKhoa`) VALUES
('MK01', 'Khoa Hệ Thống Thông Tin'),
('MK02', 'Khoa Mạng Máy Tính và Truyền Thông'),
('MK03', 'Khoa công Nghệ Phần Mềm'),
('MK04', 'KKhoa Kỹ Thuật Máy Tính');

-- --------------------------------------------------------

--
-- Table structure for table `SINHVIEN`
--

CREATE TABLE `SINHVIEN` (
  `MaSinhVien` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `TenSinhVien` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `DiemTrungBinh` float NOT NULL,
  `MaBoMon` varchar(40) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `SINHVIEN`
--

INSERT INTO `SINHVIEN` (`MaSinhVien`, `TenSinhVien`, `DiemTrungBinh`, `MaBoMon`) VALUES
('MSV01', 'Nguyễn Văn Toàn', 7, 'MBM01'),
('MSV02 ', 'Nguyễn Hồng Vy ', 8.1, 'MBM01'),
('MSV03', 'Lê Hữu Đạt ', 8.5, 'MBM02'),
('MSV04', 'Mai Xuân Hưng ', 8.7, 'MBM03'),
('MSSV05', 'Khoa', 8, 'MBM01');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `BOMON`
--
ALTER TABLE `BOMON`
  ADD PRIMARY KEY (`MaBoMon`),
  ADD KEY `FK_KHOA` (`MaKhoa`);

--
-- Indexes for table `KHOA`
--
ALTER TABLE `KHOA`
  ADD PRIMARY KEY (`MaKhoa`);

--
-- Indexes for table `SINHVIEN`
--
ALTER TABLE `SINHVIEN`
  ADD KEY `FK_BOMON` (`MaBoMon`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
