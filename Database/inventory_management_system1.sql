-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 21, 2024 at 01:22 PM
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
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `employee_id` int(1) NOT NULL,
  `first_name` varchar(20) NOT NULL,
  `last_name` varchar(20) NOT NULL,
  `contact_no` char(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`employee_id`, `first_name`, `last_name`, `contact_no`) VALUES
(1, 'Cynthia', 'Labrador', '09297607209'),
(2, 'Jonathan', 'Baraquio', '09358752308'),
(3, 'Rowena', 'Saludes', '09649868152');

-- --------------------------------------------------------

--
-- Table structure for table `local supplier`
--

CREATE TABLE `local supplier` (
  `supplier_id` int(1) NOT NULL,
  `supplier_name` varchar(20) NOT NULL,
  `contact_no` char(11) NOT NULL,
  `address` varchar(100) NOT NULL,
  `payment_terms` varchar(15) NOT NULL,
  `products_offered` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `local supplier`
--

INSERT INTO `local supplier` (`supplier_id`, `supplier_name`, `contact_no`, `address`, `payment_terms`, `products_offered`) VALUES
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
-- Table structure for table `rice category`
--

CREATE TABLE `rice category` (
  `rice_category_id` int(1) NOT NULL,
  `category_name` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rice category`
--

INSERT INTO `rice category` (`rice_category_id`, `category_name`) VALUES
(1, 'High Grade'),
(2, 'Low Grade');

-- --------------------------------------------------------

--
-- Table structure for table `storage area`
--

CREATE TABLE `storage area` (
  `area_id` int(1) NOT NULL,
  `rice_id` varchar(20) NOT NULL,
  `location` varchar(50) NOT NULL,
  `capacity` int(3) NOT NULL,
  `availability` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `storage area`
--

INSERT INTO `storage area` (`area_id`, `rice_id`, `location`, `capacity`, `availability`) VALUES
(1, '1, 3, 5, 6', 'Camambugan Central Terminal, Camambugan,  DCN', 50, 1),
(2, '2, 4, 7', 'Purok 1, Brgy. Bagasbas, DCN', 50, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`employee_id`);

--
-- Indexes for table `local supplier`
--
ALTER TABLE `local supplier`
  ADD PRIMARY KEY (`supplier_id`);

--
-- Indexes for table `rice`
--
ALTER TABLE `rice`
  ADD PRIMARY KEY (`rice_id`);

--
-- Indexes for table `rice category`
--
ALTER TABLE `rice category`
  ADD PRIMARY KEY (`rice_category_id`);

--
-- Indexes for table `storage area`
--
ALTER TABLE `storage area`
  ADD PRIMARY KEY (`area_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
