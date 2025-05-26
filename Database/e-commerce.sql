-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 02, 2024 at 03:45 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `e-commerce`
--

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `user_id` int(5) NOT NULL,
  `product_id` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cart`
--

INSERT INTO `cart` (`user_id`, `product_id`) VALUES
(1, 10),
(1, 7),
(1, 11);

-- --------------------------------------------------------

--
-- Table structure for table `prosucts`
--

CREATE TABLE `prosucts` (
  `product_id` int(5) NOT NULL,
  `product_name` varchar(20) NOT NULL,
  `product_price` int(5) NOT NULL,
  `product_photo` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `prosucts`
--

INSERT INTO `prosucts` (`product_id`, `product_name`, `product_price`, `product_photo`) VALUES
(1, 'playstation S5', 250, 'playstation.png '),
(2, 'Graphic computer', 300, 'Graphic_design_computer.png'),
(3, 'Smart Display', 400, 'Smart_display.png'),
(4, 'iphone 10 max ', 500, 'iphone_10_max.png'),
(5, 'Gaming Comuter', 800, 'Gaming_comuter.png'),
(6, 'sumsong 10 max', 7000, 'sumsong_max 10not.png'),
(7, 'iphone headphone', 250, 'iphone_headphen.png'),
(8, 'iphone laptop', 400, 'iphone_laptop.png'),
(9, 'Laptop Dell', 600, 'laptop_dell.png'),
(10, 'LG headphone', 465, 'LG_headphone.png'),
(11, 'Sumsong Laptop', 4520, 'sumsong_laptop.png');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(5) NOT NULL,
  `user_email` varchar(20) NOT NULL,
  `user_password` varchar(20) NOT NULL,
  `is_admin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `user_email`, `user_password`, `is_admin`) VALUES
(1, 'muneer200@gmail.com', 'abc123-', 0),
(2, 'admin@gmail.com', 'abc123-', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cart`
--
ALTER TABLE `cart`
  ADD KEY `cart_forienKey1` (`user_id`),
  ADD KEY `cart_forienKey2` (`product_id`);

--
-- Indexes for table `prosucts`
--
ALTER TABLE `prosucts`
  ADD PRIMARY KEY (`product_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `prosucts`
--
ALTER TABLE `prosucts`
  MODIFY `product_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cart`
--
ALTER TABLE `cart`
  ADD CONSTRAINT `cart_forienKey1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cart_forienKey2` FOREIGN KEY (`product_id`) REFERENCES `prosucts` (`product_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
