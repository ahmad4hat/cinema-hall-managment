-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 02, 2019 at 05:19 AM
-- Server version: 10.1.34-MariaDB
-- PHP Version: 7.2.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cinema_hall_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `cinema_hall`
--

CREATE TABLE `cinema_hall` (
  `id` int(10) NOT NULL,
  `name` varchar(100) NOT NULL,
  `capacity` int(10) NOT NULL,
  `location` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cinema_hall`
--

INSERT INTO `cinema_hall` (`id`, `name`, `capacity`, `location`) VALUES
(1, 'cineplex', 40, 'sks');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `id` int(10) NOT NULL,
  `email` varchar(150) NOT NULL,
  `password` varchar(100) NOT NULL,
  `dateOfBirth` varchar(300) NOT NULL,
  `address` varchar(500) NOT NULL,
  `role` varchar(100) NOT NULL,
  `gender` varchar(50) NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`id`, `email`, `password`, `dateOfBirth`, `address`, `role`, `gender`, `name`) VALUES
(1, 'islammohimenul23@gmail.com', 'jibon33107', '15-Nov-96 12:00:00 AM', 'Bashundhara', 'MD', 'Male', 'Mohaiminul');

-- --------------------------------------------------------

--
-- Table structure for table `movie`
--

CREATE TABLE `movie` (
  `id` int(10) NOT NULL,
  `title` varchar(100) NOT NULL,
  `releaseDate` varchar(100) NOT NULL,
  `description` varchar(500) NOT NULL,
  `duration` varchar(100) NOT NULL,
  `genre` varchar(100) NOT NULL,
  `director` varchar(100) NOT NULL,
  `rating` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `movie`
--

INSERT INTO `movie` (`id`, `title`, `releaseDate`, `description`, `duration`, `genre`, `director`, `rating`) VALUES
(1, 'jibon er valobasha kahani', '22 dec 2019', 'valo movie', '152min', 'prem prem', 'farhat sadman', '10/10');

-- --------------------------------------------------------

--
-- Table structure for table `movie_show`
--

CREATE TABLE `movie_show` (
  `id` int(10) NOT NULL,
  `id_movie` int(10) NOT NULL,
  `cinema_id` int(10) NOT NULL,
  `remaining_capacity` int(10) NOT NULL,
  `time` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `movie_show`
--

INSERT INTO `movie_show` (`id`, `id_movie`, `cinema_id`, `remaining_capacity`, `time`) VALUES
(1, 1, 1, 1, '2019-12-22 00:00:00.000000'),
(2, 1, 1, 2, '2019-12-21 00:00:00.000000');

-- --------------------------------------------------------

--
-- Table structure for table `ticket`
--

CREATE TABLE `ticket` (
  `id` int(10) NOT NULL,
  `movie_show_id` int(10) NOT NULL,
  `user_id` int(10) NOT NULL,
  `ticket_count` int(10) NOT NULL,
  `time_date` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `ticket`
--

INSERT INTO `ticket` (`id`, `movie_show_id`, `user_id`, `ticket_count`, `time_date`) VALUES
(2, 1, 2, 10, '2019-12-13 00:00:00.000000');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(10) NOT NULL,
  `email` varchar(150) NOT NULL,
  `password` varchar(100) NOT NULL,
  `dateOfBirth` varchar(300) NOT NULL,
  `address` varchar(500) NOT NULL,
  `gender` varchar(50) NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `email`, `password`, `dateOfBirth`, `address`, `gender`, `name`) VALUES
(1, 'farhat@gmail.com', 'asdf', '26-Jul-99 12:00:00 AM', 'dammudya', 'Male', 'farhat'),
(2, 'abc@gmail.com', '12345', '15-Nov-96 12:00:00 AM', 'Bashundhara', 'Male', 'Mohaiminul');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cinema_hall`
--
ALTER TABLE `cinema_hall`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indexes for table `movie`
--
ALTER TABLE `movie`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `movie_show`
--
ALTER TABLE `movie_show`
  ADD PRIMARY KEY (`id`),
  ADD KEY `movie_fk` (`id_movie`),
  ADD KEY `cinema_hall_fk` (`cinema_id`);

--
-- Indexes for table `ticket`
--
ALTER TABLE `ticket`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`movie_show_id`),
  ADD KEY `user_id_fk` (`user_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cinema_hall`
--
ALTER TABLE `cinema_hall`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `movie`
--
ALTER TABLE `movie`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `movie_show`
--
ALTER TABLE `movie_show`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `ticket`
--
ALTER TABLE `ticket`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `movie_show`
--
ALTER TABLE `movie_show`
  ADD CONSTRAINT `cinema_hall_fk` FOREIGN KEY (`cinema_id`) REFERENCES `cinema_hall` (`id`),
  ADD CONSTRAINT `movie_fk` FOREIGN KEY (`id_movie`) REFERENCES `movie` (`id`);

--
-- Constraints for table `ticket`
--
ALTER TABLE `ticket`
  ADD CONSTRAINT `movie-show_fk` FOREIGN KEY (`movie_show_id`) REFERENCES `movie_show` (`id`),
  ADD CONSTRAINT `user_id_fk` FOREIGN KEY (`user_id`) REFERENCES `user` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
