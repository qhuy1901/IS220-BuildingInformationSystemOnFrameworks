-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3307
-- Generation Time: Jan 01, 2022 at 02:18 PM
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
-- Database: `baotrithietbi`
--

-- --------------------------------------------------------

--
-- Table structure for table `canho`
--

CREATE TABLE `canho` (
  `MaCanHo` varchar(5) NOT NULL,
  `TenChuHo` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `canho`
--

INSERT INTO `canho` (`MaCanHo`, `TenChuHo`) VALUES
('CH01', 'Tạ Quang Huy'),
('CH02', 'Lê Thị Hồng Cúc'),
('CH03', 'Nguyễn Xuân Minh Thu'),
('CH04', 'Trần Thị Ngọc An'),
('CH05', 'Nguyễn Ảnh Trường Thắng'),
('CN06', 'Nguyễn Ảnh Trường Thắng'),
('CN49', 'Nguyễn Ảnh Trường Nam'),
('CN50', 'Nguyễn Ảnh Trường Thắng');

-- --------------------------------------------------------

--
-- Table structure for table `nhanvien`
--

CREATE TABLE `nhanvien` (
  `MaNhanVien` varchar(5) NOT NULL,
  `TenNhanVien` varchar(100) NOT NULL,
  `SoDienThoai` varchar(100) NOT NULL,
  `GioiTinh` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `nhanvien`
--

INSERT INTO `nhanvien` (`MaNhanVien`, `TenNhanVien`, `SoDienThoai`, `GioiTinh`) VALUES
('NV01', 'Võ Ngọc Cẩm Tú', '0345785412', 0),
('NV02', 'Lê Ngọc Tuấn', '09547855125', 1),
('NV03', 'Lê Ngọc Minh Thư', '03214758545', 0),
('NV04', 'Nguyễn Hoàng Thắng', '0924587561', 1);

-- --------------------------------------------------------

--
-- Table structure for table `nv_bt`
--

CREATE TABLE `nv_bt` (
  `MaNhanVien` varchar(5) NOT NULL,
  `MaThietBi` varchar(5) NOT NULL,
  `MaCanHo` varchar(5) NOT NULL,
  `LanThu` int(11) NOT NULL,
  `NgayBaoTri` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `nv_bt`
--

INSERT INTO `nv_bt` (`MaNhanVien`, `MaThietBi`, `MaCanHo`, `LanThu`, `NgayBaoTri`) VALUES
('NV01', 'TB01', 'CH03', 4, '2022-01-20'),
('NV02', 'TB04', 'CH04', 4, '2022-01-03'),
('NV04', 'TB04', 'CH04', 1, '2021-12-28');

-- --------------------------------------------------------

--
-- Table structure for table `thietbi`
--

CREATE TABLE `thietbi` (
  `MaThietBi` varchar(5) NOT NULL,
  `TenThietBi` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `thietbi`
--

INSERT INTO `thietbi` (`MaThietBi`, `TenThietBi`) VALUES
('TB01', 'Thiết bị 1'),
('TB02', 'Thiết bị 2'),
('TB03', 'Thiết bị 3'),
('TB04', 'Thiết bị 4');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `canho`
--
ALTER TABLE `canho`
  ADD PRIMARY KEY (`MaCanHo`);

--
-- Indexes for table `nhanvien`
--
ALTER TABLE `nhanvien`
  ADD PRIMARY KEY (`MaNhanVien`);

--
-- Indexes for table `nv_bt`
--
ALTER TABLE `nv_bt`
  ADD PRIMARY KEY (`MaNhanVien`,`MaThietBi`,`MaCanHo`,`LanThu`),
  ADD KEY `FK_BT_CH` (`MaCanHo`),
  ADD KEY `FK_BT_TB` (`MaThietBi`);

--
-- Indexes for table `thietbi`
--
ALTER TABLE `thietbi`
  ADD PRIMARY KEY (`MaThietBi`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `nv_bt`
--
ALTER TABLE `nv_bt`
  ADD CONSTRAINT `FK_BT_CH` FOREIGN KEY (`MaCanHo`) REFERENCES `canho` (`MaCanHo`),
  ADD CONSTRAINT `FK_BT_NV` FOREIGN KEY (`MaNhanVien`) REFERENCES `nhanvien` (`MaNhanVien`),
  ADD CONSTRAINT `FK_BT_TB` FOREIGN KEY (`MaThietBi`) REFERENCES `thietbi` (`MaThietBi`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
