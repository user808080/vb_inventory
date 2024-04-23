-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 23, 2024 at 06:12 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventory_management_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` int(11) NOT NULL COMMENT 'auto increment primary key',
  `username` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `employee_number` varchar(20) NOT NULL COMMENT 'The employee number',
  `first_name` varchar(50) NOT NULL,
  `middle_name` varchar(50) DEFAULT NULL,
  `last_name` varchar(50) NOT NULL,
  `extension_name` varchar(20) DEFAULT NULL COMMENT 'E.g. Jr, Sr. III',
  `contact_no` char(11) NOT NULL,
  `status` tinyint(1) NOT NULL DEFAULT 1,
  `date_created` datetime NOT NULL DEFAULT current_timestamp() COMMENT 'The date of insertion'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `username`, `password`, `employee_number`, `first_name`, `middle_name`, `last_name`, `extension_name`, `contact_no`, `status`, `date_created`) VALUES
(1, 'admin', 'admin', '555', 'Juan', 'Tanggol', 'Delacruz', NULL, '099999999', 1, '2024-04-23 10:14:17');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `id` int(11) NOT NULL COMMENT 'auto increment primary key',
  `username` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `employee_number` varchar(20) NOT NULL COMMENT 'The employee number',
  `first_name` varchar(50) NOT NULL,
  `middle_name` varchar(50) DEFAULT NULL,
  `last_name` varchar(50) NOT NULL,
  `extension_name` varchar(20) DEFAULT NULL COMMENT 'E.g. Jr, Sr. III',
  `contact_no` char(11) NOT NULL,
  `status` tinyint(1) NOT NULL DEFAULT 1,
  `date_created` datetime NOT NULL DEFAULT current_timestamp() COMMENT 'The date of insertion'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `local_supplier`
--

CREATE TABLE `local_supplier` (
  `supplier_id` int(1) NOT NULL,
  `supplier_name` varchar(20) NOT NULL,
  `contact_no` char(11) NOT NULL,
  `address` varchar(100) NOT NULL,
  `payment_terms` varchar(15) NOT NULL,
  `products_offered` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `local_supplier`
--

INSERT INTO `local_supplier` (`supplier_id`, `supplier_name`, `contact_no`, `address`, `payment_terms`, `products_offered`) VALUES
(1, 'Ren Liwanag', '09164436312', 'Ninoy Aquino Avenue Brgy. 7 Bagasbas Road, Daet, 4600 Camarines Norte', 'Gcash, Cash', 'Dinorado, Sinandomeng, Bulaw, C4'),
(2, 'Cynthia Tanchuling', '09555036637', 'Ninoy Aquino Avenue Brgy. 7 Bagasbas Road, Daet, 4600 Camarines Norte', 'Cash', 'Jasmine, Thai, Vietnam');

-- --------------------------------------------------------

--
-- Table structure for table `rice`
--

CREATE TABLE `rice` (
  `rice_id` int(1) NOT NULL,
  `rice_category_id` int(1) NOT NULL,
  `supplier_id` int(1) NOT NULL,
  `rice_name` varchar(20) NOT NULL,
  `purchase_price` decimal(10,0) NOT NULL,
  `unit_price` decimal(10,0) NOT NULL COMMENT 'Kuha sa supplier Per Kilo',
  `selling_price` decimal(10,0) NOT NULL COMMENT 'Benta Per Kilo',
  `stock_level` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rice`
--

INSERT INTO `rice` (`rice_id`, `rice_category_id`, `supplier_id`, `rice_name`, `purchase_price`, `unit_price`, `selling_price`, `stock_level`) VALUES
(1, 1, 1, 'Dinorado Rice', '2650', '53', '56', 10),
(2, 1, 1, 'Sinandomeng Rice', '2670', '54', '57', 9),
(3, 2, 1, 'Bulaw Rice', '2400', '48', '51', 8),
(4, 2, 1, 'C4 Rice', '2380', '48', '51', 7),
(5, 1, 2, 'Jasmine Rice', '2800', '56', '60', 8),
(6, 1, 2, 'Thai Rice', '2730', '55', '58', 9),
(7, 1, 2, 'Vietnam Rice', '2620', '53', '56', 10);

-- --------------------------------------------------------

--
-- Table structure for table `rice_category`
--

CREATE TABLE `rice_category` (
  `rice_category_id` int(1) NOT NULL,
  `category_name` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rice_category`
--

INSERT INTO `rice_category` (`rice_category_id`, `category_name`) VALUES
(1, 'High Grade'),
(2, 'Low Grade');

-- --------------------------------------------------------

--
-- Table structure for table `storage_area`
--

CREATE TABLE `storage_area` (
  `area_id` int(1) NOT NULL,
  `rice_id` varchar(20) NOT NULL,
  `location` varchar(50) NOT NULL,
  `capacity` int(3) NOT NULL,
  `availability` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `storage_area`
--

INSERT INTO `storage_area` (`area_id`, `rice_id`, `location`, `capacity`, `availability`) VALUES
(1, '1, 3, 5, 6', 'Camambugan Central Terminal, Camambugan,  DCN', 50, 1),
(2, '2, 4, 7', 'Purok 1, Brgy. Bagasbas, DCN', 50, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `local_supplier`
--
ALTER TABLE `local_supplier`
  ADD PRIMARY KEY (`supplier_id`);

--
-- Indexes for table `rice`
--
ALTER TABLE `rice`
  ADD PRIMARY KEY (`rice_id`);

--
-- Indexes for table `rice_category`
--
ALTER TABLE `rice_category`
  ADD PRIMARY KEY (`rice_category_id`);

--
-- Indexes for table `storage_area`
--
ALTER TABLE `storage_area`
  ADD PRIMARY KEY (`area_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'auto increment primary key', AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'auto increment primary key', AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
