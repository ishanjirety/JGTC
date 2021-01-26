-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 26, 2021 at 02:29 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.2.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `jgtc`
--

-- --------------------------------------------------------

--
-- Table structure for table `accountingyear`
--

CREATE TABLE `accountingyear` (
  `Status` varchar(6) NOT NULL,
  `Start` varchar(20) NOT NULL,
  `End` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `accountingyear`
--

INSERT INTO `accountingyear` (`Status`, `Start`, `End`) VALUES
('TRUE', '01-01-2022', '31-12-2022');

-- --------------------------------------------------------

--
-- Table structure for table `balances`
--

CREATE TABLE `balances` (
  `Date_of_bal` varchar(20) NOT NULL,
  `ledgername` varchar(20) NOT NULL,
  `Prev_Denote` varchar(5) NOT NULL DEFAULT '0',
  `Prev_B/D` varchar(20) NOT NULL DEFAULT '0',
  `Cur_Denote` varchar(5) NOT NULL DEFAULT '0',
  `Cur_B/D` varchar(20) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `balances`
--

INSERT INTO `balances` (`Date_of_bal`, `ledgername`, `Prev_Denote`, `Prev_B/D`, `Cur_Denote`, `Cur_B/D`) VALUES
('2020', 'CashBook', 'Cr', '0', 'Cr', '0'),
('2020', 'sabziBazar', 'Cr', '0', 'Cr', '12500'),
('2021', 'rajkumar jirety', '', '', 'Cr', '0'),
('2021', 'RK Jirety', '', '', 'Dr', '1200'),
('2021', 'RKJI', '', '', 'Cr', '0'),
('2021', 'sabziBazar', 'Cr', '9000', 'Cr', '9600'),
('2021', 'CashBook', 'Cr', '0', 'Cr', '0'),
('2020', 'rajkumar jirety', 'Cr', '0', 'Dr', '22500'),
('2020', 'rk jirety', 'Cr', '0', 'Dr', '57680'),
('2020', 'rkji', 'Cr', '0', 'Dr', '16700'),
('2020', 'myname', 'Cr', '0', 'Cr', '0');

-- --------------------------------------------------------

--
-- Table structure for table `cashbook`
--

CREATE TABLE `cashbook` (
  `DATE` varchar(20) NOT NULL,
  `DENOTE` varchar(5) NOT NULL,
  `PARTICULAR` varchar(30) NOT NULL,
  `AMOUNT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cashbook`
--

INSERT INTO `cashbook` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES
('22-11-2020', 'BY', 'purchasea/c', '1200'),
('26-11-2020', 'TO', 'salesa/c', '1200'),
('29-11-2022', 'TO', 'salesa/c', '1200'),
('29-11-2023', 'TO', 'salesa/c', '3600');

-- --------------------------------------------------------

--
-- Table structure for table `challan`
--

CREATE TABLE `challan` (
  `challan_id` int(11) NOT NULL,
  `challan_addr` varchar(50) NOT NULL,
  `challan_orderNo` varchar(50) NOT NULL,
  `challan_orderdate` varchar(50) NOT NULL,
  `challan_prodCode` varchar(20) NOT NULL,
  `challan_prodQty` varchar(20) NOT NULL,
  `challan_totAmt` varchar(20) NOT NULL,
  `challan_freight` varchar(20) NOT NULL,
  `challan_prodDesc` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `depriciation_method`
--

CREATE TABLE `depriciation_method` (
  `Method` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `depriciation_method`
--

INSERT INTO `depriciation_method` (`Method`) VALUES
('WDVM');

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `inv_id` int(11) NOT NULL,
  `inv_itemName` varchar(20) NOT NULL,
  `inv_itemQty` varchar(20) NOT NULL,
  `amount` varchar(20) NOT NULL,
  `EntryDate` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`inv_id`, `inv_itemName`, `inv_itemQty`, `amount`, `EntryDate`) VALUES
(16, 'Onion', ' 0', '50', '17-11-2020 AM 01:56:'),
(17, 'aloo', ' 28', '40', '18-11-2020 PM 07:38:');

-- --------------------------------------------------------

--
-- Table structure for table `ishanraiders`
--

CREATE TABLE `ishanraiders` (
  `DATE` varchar(20) NOT NULL,
  `DENOTE` varchar(5) NOT NULL,
  `PARTICULAR` varchar(30) NOT NULL,
  `AMOUNT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ishanraiders`
--

INSERT INTO `ishanraiders` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES
('19-11-2020', 'BY', 'purchasea/c', '1200'),
('19-11-2020', 'BY', 'purchasea/c', '40'),
('20-11-2020', 'BY', 'purchasea/c', '1200');

-- --------------------------------------------------------

--
-- Table structure for table `ishantraders`
--

CREATE TABLE `ishantraders` (
  `DATE` varchar(20) NOT NULL,
  `DENOTE` varchar(5) NOT NULL,
  `PARTICULAR` varchar(30) NOT NULL,
  `AMOUNT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ishantraders`
--

INSERT INTO `ishantraders` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES
('19-11-2020', 'BY', 'purchasea/c', '1200');

-- --------------------------------------------------------

--
-- Table structure for table `ledgernames`
--

CREATE TABLE `ledgernames` (
  `Name` varchar(20) NOT NULL,
  `AffectsInventory` varchar(5) NOT NULL,
  `CUSNAME` varchar(20) NOT NULL,
  `ADDRESS` varchar(40) NOT NULL,
  `MOBILE` varchar(15) NOT NULL,
  `BANKDETAILS` varchar(40) NOT NULL,
  `Category` varchar(20) NOT NULL,
  `LedNumber` int(11) NOT NULL,
  `DateOfCreation` varchar(20) NOT NULL,
  `refference` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ledgernames`
--

INSERT INTO `ledgernames` (`Name`, `AffectsInventory`, `CUSNAME`, `ADDRESS`, `MOBILE`, `BANKDETAILS`, `Category`, `LedNumber`, `DateOfCreation`, `refference`) VALUES
('M/s Rakesh', 'NO', 'NULL', 'NULL', 'NULL', 'NULL', '0', 1, '', ''),
('purchasea/c', 'YES', 'NULL', 'NULL', 'NULL', 'NULL', '0', 2, '', ''),
('M/s Ishan&co', 'NO', 'NULL', 'NULL', 'NULL', 'NULL', '0', 3, '18-11-2020 AM 02:39:', ''),
('M/s Jirety', 'YES', 'NULL', 'NULL', 'NULL', 'NULL', '0', 4, '18-11-2020 AM 02:40:', ''),
('ManojTraders', 'YES', 'Manoj', 'Jaipur', '8878005371', 'PNB', '0', 5, '19-11-2020 PM 07:03:', ''),
('m/s KishanTrading', 'NO', 'Kishan', 'Jaipur', '123456789', 'PNB', '0', 6, '19-11-2020 PM 07:17:', ''),
('IshanTraders', 'NO', 'NULL', 'NULL', 'NULL', 'NULL', '0', 7, '19-11-2020 PM 07:28:', ''),
('ishanRaiders', 'NO', 'ishan', '21/2', '8878005371', 'PNB', '0', 8, '19-11-2020 PM 07:31:', ''),
('obckjakhwda', 'NO', 'awdaw', 'wdawdawd', 'awdawd', 'awdawdaw', '0', 9, '19-11-2020 PM 07:33:', ''),
('salesa/c', 'YES', 'NULL', 'NULL', 'NULL', 'NULL', '', 10, '22-11-2020 AM 12:53:', ''),
('sabziBazar', 'YES', 'Mukesh', 'gutke wala', '123456789', 'PNB', 'Sundry Creditors', 11, '22-11-2020 PM 04:15:', ''),
('CashBook', 'NO', 'NULL', 'NULL', 'NULL', 'NULL', 'Cash ', 12, '22-11-2020 PM 04:17:', ''),
('rajkumar jirety', 'NO', 'Rajkumar Jirety', 'Indore', '9584629783', 'PNB', 'Sundry Debtors', 13, '23-11-2020 PM 07:20:', ''),
('RK Jirety', 'NO', 'Rajkumar Jirety', 'Manoramaganj 22 alok Appartment 452001', '9584629783', 'PNB,PUB1234', 'Sundry Debtors', 14, '23-11-2020 PM 08:37:', ''),
('RKJI', 'NO', 'RkJI', '21/2', '8878005371', 'PUB', 'Sundry Debtors', 15, '24-11-2020 AM 01:13:', ''),
('Myname', 'NO', 'NULL', 'NULL', 'NULL', 'NULL', 'Fixed Assets', 16, '28-11-2020 PM 08:02:', '');

-- --------------------------------------------------------

--
-- Table structure for table `logs`
--

CREATE TABLE `logs` (
  `log_ID` int(11) NOT NULL,
  `log_username` varchar(20) NOT NULL,
  `log_role` varchar(20) NOT NULL,
  `log_pc` varchar(20) NOT NULL,
  `log_ip` varchar(25) NOT NULL,
  `last_login_date` varchar(20) NOT NULL,
  `last_login_time` varchar(20) NOT NULL,
  `last_logout_time` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `logs`
--

INSERT INTO `logs` (`log_ID`, `log_username`, `log_role`, `log_pc`, `log_ip`, `last_login_date`, `last_login_time`, `last_logout_time`) VALUES
(8, 'ishan', '', 'ISHAN-PC', '192.168.43.198', '03-11-2020', '07:48:02 PM', '07:48:04 PM'),
(9, 'ishan', '', 'ISHAN-PC', '192.168.43.198', '04-11-2020', '07:48:26 PM', '07:48:48 PM'),
(10, 'ishan', '', 'ISHAN-PC', '192.168.43.198', '05-11-2020', '06:13:36 PM', '08:40:42 PM'),
(11, 'ishan', '', 'ISHAN-PC', '192.168.43.198', '06-11-2020', '11:19:58 AM', '08:03:49 PM'),
(14, 'vaishnavi', '', 'LAPTOP-8KT70RA4', '192.168.29.31', '07-11-2020', '04:12:10 PM', '06:13:09 PM'),
(15, 'gujju', '', 'ISHAN-PC', '192.168.43.198', '07-11-2020', '04:15:36 PM', '06:13:09 PM'),
(16, 'ishan', '', 'DESKTOP-QNJPUO9', '192.168.35.2', '07/11/2020', '04:55:20 PM', '05:07:07 PM'),
(17, 'yashi', '', 'lenovo-PC', '192.168.29.25', '07-11-2020', '06:04:59 PM', '06:13:09 PM'),
(18, 'ishan', '', 'ISHAN-PC', '192.168.43.198', '08-11-2020', '07:24:53 PM', '07:52:28 PM'),
(19, 'ishan', '', 'ISHAN-PC', '192.168.43.198', '09-11-2020', '04:19:09 PM', '05:08:56 PM'),
(20, 'ishan', '', 'ISHAN-PC', '192.168.43.198', '10-11-2020', '10:31:20 PM', '10:43:36 PM'),
(21, 'ishan', '', 'ISHAN-PC', '192.168.1.139', '15-11-2020', '05:09:34 PM', '07:28:21 PM'),
(22, 'ishan', '', 'ISHAN-PC', '192.168.1.139', '16-11-2020', '12:25:10 AM', '05:11:07 PM'),
(23, 'ishan', '', 'ISHAN-PC', '192.168.43.198', '18-11-2020', '05:06:30 PM', '07:22:46 PM'),
(24, 'ishan', '', 'ISHAN-PC', '192.168.43.198', '19-11-2020', '05:27:37 PM', '07:42:53 PM'),
(25, 'ishan', '', 'ISHAN-PC', '192.168.43.198', '30-11-2020', '01:10:38 PM', '01:28:44 PM'),
(26, 'ishan', '', 'ISHAN-PC', '192.168.43.198', '31-12-2020', '09:00:06 PM', '09:12:24 PM'),
(27, 'ishan', '', 'ISHAN-PC', '192.168.43.198', '31-12-2021', '09:12:44 PM', '09:14:24 PM'),
(28, 'ishan', '', 'ISHAN-PC', '192.168.43.198', '01-12-2020', '04:07:06 PM', '04:07:25 PM'),
(29, 'ishan', '', 'ISHAN-PC', '192.168.43.198', '02-12-2020', '09:07:49 PM', '09:11:57 PM'),
(30, 'ishan', '', 'ISHAN-PC', '192.168.1.139', '06-12-2020', '06:50:40 PM', '06:51:18 PM'),
(31, 'ishan', '', 'ISHAN-PC', '192.168.1.139', '08-12-2020', '04:34:57 PM', '05:11:44 PM');

-- --------------------------------------------------------

--
-- Table structure for table `m/s ishan&co`
--

CREATE TABLE `m/s ishan&co` (
  `DATE` varchar(20) NOT NULL,
  `DENOTE` varchar(5) NOT NULL,
  `PARTICULAR` varchar(30) NOT NULL,
  `AMOUNT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `m/s ishan&co`
--

INSERT INTO `m/s ishan&co` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES
('18-11-2020', 'BY', 'Purchase a/c', '600'),
('18-11-2020', 'BY', 'Purchase a/c', '4800'),
('18-11-2020', 'BY', 'Purchase a/c', '1000'),
('18-11-2020', 'BY', 'Purchase a/c', '600'),
('18-11-2020', 'BY', 'Purchase a/c', '1200'),
('21-11-2020', 'BY', 'purchasea/c', '600'),
('21-11-2020', 'BY', 'purchasea/c', '600'),
('21-11-2020', 'BY', 'purchasea/c', '60'),
('21-11-2020', 'BY', 'purchasea/c', '1500'),
('22-11-2020', 'TO', 'salesa/c', '1200'),
('22-11-2020', 'TO', 'salesa/c', '600'),
('22-11-2020', 'TO', 'salesa/c', '120');

-- --------------------------------------------------------

--
-- Table structure for table `m/s jirety`
--

CREATE TABLE `m/s jirety` (
  `DATE` varchar(20) NOT NULL,
  `DENOTE` varchar(5) NOT NULL,
  `PARTICULAR` varchar(30) NOT NULL,
  `AMOUNT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `m/s jirety`
--

INSERT INTO `m/s jirety` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES
('18-11-2020', 'BY', 'Purchase a/c', '3000'),
('18-11-2020', 'BY', 'Purchase a/c', '1200'),
('18-11-2020', 'BY', 'Purchase a/c', '6000'),
('21-11-2020', 'BY', 'purchasea/c', '600'),
('22-11-2020', 'TO', 'salesa/c', '2800'),
('22-11-2020', 'TO', 'salesa/c', '1500'),
('22-11-2020', 'TO', 'salesa/c', '1200');

-- --------------------------------------------------------

--
-- Table structure for table `m/s kishantrading`
--

CREATE TABLE `m/s kishantrading` (
  `DATE` varchar(20) NOT NULL,
  `DENOTE` varchar(5) NOT NULL,
  `PARTICULAR` varchar(30) NOT NULL,
  `AMOUNT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `m/s kishantrading`
--

INSERT INTO `m/s kishantrading` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES
('19-11-2020', 'BY', 'purchasea/c', '1200');

-- --------------------------------------------------------

--
-- Table structure for table `m/s rakesh`
--

CREATE TABLE `m/s rakesh` (
  `DATE` varchar(20) NOT NULL,
  `DENOTE` varchar(5) NOT NULL,
  `PARTICULAR` varchar(30) NOT NULL,
  `AMOUNT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `m/s rakesh`
--

INSERT INTO `m/s rakesh` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES
('18-11-2020', 'BY', 'Purchase a/c', '1200'),
('18-11-2020', 'BY', 'Purchase a/c', '1800'),
('18-11-2020', 'BY', 'Purchase a/c', '600'),
('18-11-2020', 'BY', 'Purchase a/c', '1200'),
('18-11-2020', 'BY', 'Purchase a/c', '1200'),
('18-11-2020', 'BY', 'Purchase a/c', '900'),
('18-11-2020', 'BY', 'Purchase a/c', '1200'),
('18-11-2020', 'BY', 'Purchase a/c', '1500'),
('18-11-2020', 'BY', 'Purchase a/c', '1200'),
('18-11-2020', 'BY', 'Purchase a/c', '1200'),
('18-11-2020', 'BY', 'Purchase a/c', '1200'),
('18-11-2020', 'BY', 'Purchase a/c', '1200'),
('18-11-2020', 'BY', 'Purchase a/c', '1200'),
('18-11-2020', 'BY', 'Purchase a/c', '1200'),
('18-11-2020', 'BY', 'Purchase a/c', '180'),
('18-11-2020', 'BY', 'Purchase a/c', '1200'),
('18-11-2020', 'BY', 'Purchase a/c', '1800'),
('20-11-2020', 'TO', 'cash a/c', '5000'),
('21-11-2020', 'BY', 'purchasea/c', '1800'),
('21-11-2020', 'BY', 'purchasea/c', '600');

-- --------------------------------------------------------

--
-- Table structure for table `manojtraders`
--

CREATE TABLE `manojtraders` (
  `DATE` varchar(20) NOT NULL,
  `DENOTE` varchar(5) NOT NULL,
  `PARTICULAR` varchar(30) NOT NULL,
  `AMOUNT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `manojtraders`
--

INSERT INTO `manojtraders` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES
('19-11-2020', 'BY', 'purchasea/c', '600'),
('19-11-2020', 'BY', 'purchasea/c', '1320'),
('19-11-2020', 'BY', 'purchasea/c', '1800'),
('21-11-2020', 'BY', 'purchasea/c', '600');

-- --------------------------------------------------------

--
-- Table structure for table `msgbody`
--

CREATE TABLE `msgbody` (
  `Msg` varchar(400) NOT NULL,
  `Exist` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `msgbody`
--

INSERT INTO `msgbody` (`Msg`, `Exist`) VALUES
('Namaste! Your Bill Of & Rs. Has Been Generated At Our Store\nRegards,\nJai Gurudev Trading Company', 'True');

-- --------------------------------------------------------

--
-- Table structure for table `myname`
--

CREATE TABLE `myname` (
  `DATE` varchar(20) NOT NULL,
  `DENOTE` varchar(5) NOT NULL,
  `PARTICULAR` varchar(30) NOT NULL,
  `AMOUNT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `obckjakhwda`
--

CREATE TABLE `obckjakhwda` (
  `DATE` varchar(20) NOT NULL,
  `DENOTE` varchar(5) NOT NULL,
  `PARTICULAR` varchar(30) NOT NULL,
  `AMOUNT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `obckjakhwda`
--

INSERT INTO `obckjakhwda` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES
('19-11-2020', 'BY', 'purchasea/c', '0'),
('20-11-2020', 'BY', 'purchasea/c', '1200'),
('21-11-2020', 'BY', 'purchasea/c', '600'),
('21-11-2020', 'BY', 'purchasea/c', '1200'),
('21-11-2020', 'BY', 'purchasea/c', '600');

-- --------------------------------------------------------

--
-- Table structure for table `purchase`
--

CREATE TABLE `purchase` (
  `PurchaseID` int(11) NOT NULL,
  `VoucherNo` varchar(20) NOT NULL,
  `ItemName` varchar(30) NOT NULL,
  `ItemQty` varchar(10) NOT NULL,
  `Rate` varchar(20) NOT NULL,
  `Amount` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `purchase`
--

INSERT INTO `purchase` (`PurchaseID`, `VoucherNo`, `ItemName`, `ItemQty`, `Rate`, `Amount`) VALUES
(2, '52', 'aloo', '20', '30', '600'),
(3, '53', 'aloo', '50', '30', '1500'),
(4, '60', 'Onion', '40', '30', '1200'),
(5, '61', 'onion', '40', '30', '1200'),
(6, '62', 'Onion', '20', '30', '600'),
(7, '63', 'Onion', '30', '40', '1200'),
(8, '85', 'Onion', '20', '30', '600'),
(9, '87', 'Onion', '60', '40', '2400'),
(10, '89', 'Onion', '60', '60', '3600'),
(11, '90', 'onion', '40', '30', '1200'),
(12, '94', 'Onion', '100', '35', '3500');

-- --------------------------------------------------------

--
-- Table structure for table `purchasea/c`
--

CREATE TABLE `purchasea/c` (
  `DATE` varchar(20) NOT NULL,
  `DENOTE` varchar(5) NOT NULL,
  `PARTICULAR` varchar(30) NOT NULL,
  `AMOUNT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `purchasea/c`
--

INSERT INTO `purchasea/c` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES
('today', 'TO', 'manojTraders', '600'),
('19-11-2020', 'TO', 'ManojTraders', '1800'),
('19-11-2020', 'TO', 'm/s KishanTrading', '1200'),
('19-11-2020', 'TO', 'ishanRaiders', '1200'),
('19-11-2020', 'TO', 'obckjakhwda', '0'),
('19-11-2020', 'TO', 'ishanRaiders', '40'),
('19-11-2020', 'TO', 'IshanTraders', '1200'),
('20-11-2020', 'TO', 'ishanRaiders', '1200'),
('20-11-2020', 'TO', 'obckjakhwda', '1200'),
('21-11-2020', 'TO', 'M/s Rakesh', '1800'),
('21-11-2020', 'TO', 'M/s Ishan&co', '600'),
('21-11-2020', 'TO', 'M/s Jirety', '600'),
('21-11-2020', 'TO', 'obckjakhwda', '600'),
('21-11-2020', 'TO', 'M/s Ishan&co', '600'),
('21-11-2020', 'TO', 'M/s Ishan&co', '60'),
('21-11-2020', 'TO', 'M/s Rakesh', '600'),
('21-11-2020', 'TO', 'ManojTraders', '600'),
('21-11-2020', 'TO', 'obckjakhwda', '1200'),
('21-11-2020', 'TO', 'obckjakhwda', '600'),
('21-11-2020', 'TO', 'M/s Ishan&co', '1500'),
('22-11-2020', 'TO', 'CashBook', '1200'),
('22-11-2020', 'TO', 'sabziBazar', '1200'),
('22-11-2020', 'TO', 'sabziBazar', '600'),
('23-11-2020', 'TO', 'sabziBazar', '1200'),
('25-11-2021', 'TO', 'sabziBazar', '600'),
('26-11-2020', 'TO', 'sabziBazar', '2400'),
('29-11-2020', 'TO', 'sabziBazar', '3600'),
('29-11-2022', 'TO', 'sabziBazar', '1200'),
('02-12-2020', 'TO', 'sabzibazar', '3500');

-- --------------------------------------------------------

--
-- Table structure for table `rajkumar jirety`
--

CREATE TABLE `rajkumar jirety` (
  `DATE` varchar(20) NOT NULL,
  `DENOTE` varchar(5) NOT NULL,
  `PARTICULAR` varchar(30) NOT NULL,
  `AMOUNT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rajkumar jirety`
--

INSERT INTO `rajkumar jirety` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES
('23-11-2020', 'TO', 'salesa/c', '6000'),
('23-11-2020', 'TO', 'salesa/c', '2400'),
('23-11-2020', 'TO', 'salesa/c', '2400'),
('23-11-2020', 'TO', 'salesa/c', '5700'),
('23-11-2020', 'TO', 'salesa/c', '5400'),
('24-11-2020', 'TO', 'salesa/c', '600');

-- --------------------------------------------------------

--
-- Table structure for table `retail`
--

CREATE TABLE `retail` (
  `retail_id` int(11) NOT NULL,
  `retail_name` varchar(50) DEFAULT NULL,
  `retail_addr` varchar(50) DEFAULT NULL,
  `retail_phone` varchar(50) NOT NULL,
  `retail_remarks` varchar(20) DEFAULT NULL,
  `retail_prodName` varchar(50) DEFAULT NULL,
  `retail_itemCode` varchar(20) NOT NULL,
  `retail_pcs` varchar(20) DEFAULT NULL,
  `retail_mode` varchar(50) DEFAULT NULL,
  `retail_amount` varchar(50) DEFAULT NULL,
  `retail_discAllowed` varchar(20) NOT NULL,
  `retail_purDate` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `rkji`
--

CREATE TABLE `rkji` (
  `DATE` varchar(20) NOT NULL,
  `DENOTE` varchar(5) NOT NULL,
  `PARTICULAR` varchar(30) NOT NULL,
  `AMOUNT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rkji`
--

INSERT INTO `rkji` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES
('25-11-2020', 'TO', 'salesa/c', '1500'),
('25-11-2020', 'TO', 'salesa/c', '1200'),
('02-12-2020', 'TO', 'salesa/c', '14000'),
('08-12-2020', 'TO', 'salesa/c', '200');

-- --------------------------------------------------------

--
-- Table structure for table `rk jirety`
--

CREATE TABLE `rk jirety` (
  `DATE` varchar(20) NOT NULL,
  `DENOTE` varchar(5) NOT NULL,
  `PARTICULAR` varchar(30) NOT NULL,
  `AMOUNT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rk jirety`
--

INSERT INTO `rk jirety` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES
('23-11-2020', 'TO', 'salesa/c', '1280'),
('24-11-2020', 'TO', 'salesa/c', '6000'),
('24-11-2020', 'TO', 'salesa/c', '12000'),
('24-11-2020', 'TO', 'salesa/c', '1200'),
('24-11-2020', 'TO', 'salesa/c', '2400'),
('24-11-2020', 'TO', 'salesa/c', '1200'),
('24-11-2020', 'TO', 'salesa/c', '24000'),
('24-11-2020', 'TO', 'salesa/c', '600'),
('24-11-2020', 'TO', 'salesa/c', '600'),
('24-11-2020', 'TO', 'salesa/c', '600'),
('24-11-2020', 'TO', 'salesa/c', '1200'),
('25-11-2020', 'TO', 'salesa/c', '6000'),
('25-11-2021', 'TO', 'salesa/c', '1200'),
('27-11-2020', 'TO', 'salesa/c', '600'),
('29-11-2022', 'TO', 'salesa/c', '2400');

-- --------------------------------------------------------

--
-- Table structure for table `roles`
--

CREATE TABLE `roles` (
  `role_name` varchar(20) NOT NULL,
  `bills` varchar(6) NOT NULL DEFAULT 'False',
  `accounts` varchar(6) NOT NULL DEFAULT 'False',
  `inventory` varchar(6) NOT NULL DEFAULT 'False',
  `payroll` varchar(6) NOT NULL DEFAULT 'False',
  `analytics` varchar(6) NOT NULL DEFAULT 'False',
  `vouchers` varchar(6) NOT NULL DEFAULT 'False',
  `active_users` varchar(6) NOT NULL DEFAULT 'False'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `roles`
--

INSERT INTO `roles` (`role_name`, `bills`, `accounts`, `inventory`, `payroll`, `analytics`, `vouchers`, `active_users`) VALUES
('Manager', 'True', 'True', 'False', 'True', 'True', 'False', 'True'),
('Admin', 'True', 'True', 'True', 'True', 'True', 'True', 'True'),
('Manage', 'False', 'False', 'False', 'False', 'False', 'False', 'True'),
('NewRole', 'False', 'False', 'True', 'True', 'True', 'False', 'True');

-- --------------------------------------------------------

--
-- Table structure for table `sabzibazar`
--

CREATE TABLE `sabzibazar` (
  `DATE` varchar(20) NOT NULL,
  `DENOTE` varchar(5) NOT NULL,
  `PARTICULAR` varchar(30) NOT NULL,
  `AMOUNT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sabzibazar`
--

INSERT INTO `sabzibazar` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES
('22-11-2020', 'BY', 'purchasea/c', '1200'),
('22-11-2020', 'BY', 'purchasea/c', '600'),
('23-11-2020', 'BY', 'purchasea/c', '1200'),
('25-11-2021', 'BY', 'purchasea/c', '600'),
('26-11-2020', 'BY', 'purchasea/c', '2400'),
('29-11-2020', 'BY', 'purchasea/c', '3600'),
('29-11-2022', 'BY', 'purchasea/c', '1200'),
('02-12-2020', 'BY', 'purchasea/c', '3500');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `SaleID` int(11) NOT NULL,
  `VoucherNo` varchar(20) NOT NULL,
  `ItemName` varchar(30) NOT NULL,
  `ItemQty` varchar(10) NOT NULL,
  `Rate` varchar(20) NOT NULL,
  `Amount` varchar(20) NOT NULL,
  `partyName` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`SaleID`, `VoucherNo`, `ItemName`, `ItemQty`, `Rate`, `Amount`, `partyName`) VALUES
(1, '54', 'Onion', '30', '40', '1200', ''),
(2, '55', 'Onion', '70', '40', '2800', ''),
(3, '56', 'aloo', '20', '30', '600', ''),
(4, '56', 'Onion', '30', '30', '900', ''),
(5, '57', 'Onion', '30', '40', '1200', ''),
(6, '58', 'Onion', '20', '30', '600', 'M/s Ishan&co'),
(7, '59', 'Onion', '4', '30', '120', 'M/s Ishan&co'),
(8, '64', 'onion', '100', '60', '6000', 'rajkumar jirety'),
(9, '65', 'Onion', '40', '60', '2400', 'rajkumar jirety'),
(10, '66', 'aloo', '60', '40', '2400', 'rajkumar jirety'),
(11, '67', 'onion', '30', '50', '1500', 'rajkumar jirety'),
(12, '67', 'aloo', '60', '70', '4200', 'rajkumar jirety'),
(13, '68', 'onion', '60', '90', '5400', 'rajkumar jirety'),
(14, '69', 'aloo', '32', '40', '1280', 'RK Jirety'),
(15, '70', 'Onion', '200', '30', '6000', 'RK Jirety'),
(16, '71', 'Onion', '300', '40', '12000', 'RK Jirety'),
(17, '72', 'Onion', '30', '40', '1200', 'RK Jirety'),
(18, '73', 'onion', '40', '60', '2400', 'RK Jirety'),
(19, '74', 'Onion', '30', '40', '1200', 'RK Jirety');

-- --------------------------------------------------------

--
-- Table structure for table `salesa/c`
--

CREATE TABLE `salesa/c` (
  `DATE` varchar(20) NOT NULL,
  `DENOTE` varchar(5) NOT NULL,
  `PARTICULAR` varchar(30) NOT NULL,
  `AMOUNT` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `salesa/c`
--

INSERT INTO `salesa/c` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES
('22-11-2020', 'BY', 'M/s Ishan&co', '1200'),
('22-11-2020', 'BY', 'M/s Jirety', '2800'),
('22-11-2020', 'BY', 'M/s Jirety', '1500'),
('22-11-2020', 'BY', 'M/s Jirety', '1200'),
('22-11-2020', 'BY', 'M/s Ishan&co', '600'),
('22-11-2020', 'BY', 'M/s Ishan&co', '120'),
('23-11-2020', 'BY', 'rajkumar jirety', '6000'),
('23-11-2020', 'BY', 'rajkumar jirety', '2400'),
('23-11-2020', 'BY', 'rajkumar jirety', '2400'),
('23-11-2020', 'BY', 'rajkumar jirety', '5700'),
('23-11-2020', 'BY', 'rajkumar jirety', '5400'),
('23-11-2020', 'BY', 'RK Jirety', '1280'),
('24-11-2020', 'BY', 'RK Jirety', '6000'),
('24-11-2020', 'BY', 'RK Jirety', '12000'),
('24-11-2020', 'BY', 'RK Jirety', '1200'),
('24-11-2020', 'BY', 'RK Jirety', '2400'),
('24-11-2020', 'BY', 'RK Jirety', '1200'),
('24-11-2020', 'BY', 'RK Jirety', '24000'),
('24-11-2020', 'BY', 'RK Jirety', '600'),
('24-11-2020', 'BY', 'RK Jirety', '600'),
('24-11-2020', 'BY', 'RK Jirety', '600'),
('24-11-2020', 'BY', 'RK Jirety', '1200'),
('24-11-2020', 'BY', 'rajkumar jirety', '600'),
('25-11-2020', 'BY', 'RK Jirety', '6000'),
('25-11-2020', 'BY', 'RKJI', '1500'),
('25-11-2020', 'BY', 'RKJI', '1200'),
('25-11-2021', 'BY', 'RK Jirety', '1200'),
('26-11-2020', 'BY', 'CashBook', '1200'),
('27-11-2020', 'BY', 'RK Jirety', '600'),
('29-11-2022', 'BY', 'RK Jirety', '2400'),
('29-11-2022', 'BY', 'CashBook', '1200'),
('29-11-2023', 'BY', 'CashBook', '3600'),
('02-12-2020', 'BY', 'rkji', '14000'),
('08-12-2020', 'BY', 'rkji', '200');

-- --------------------------------------------------------

--
-- Table structure for table `userlogin`
--

CREATE TABLE `userlogin` (
  `usr_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `role` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `userlogin`
--

INSERT INTO `userlogin` (`usr_id`, `username`, `password`, `role`) VALUES
(15, 'ishan', 'PMF5TyKytwC2ISGzTsRFcg==', 'Admin'),
(16, 'jirety', 'vcuJDEunKuPZnRSKtnaJTg==', 'Manager'),
(19, 'adwa', '/CRiNkLg+NU=', 'Manager'),
(20, 'ayush', '8zLRrrhyeaDlFVfEtO6OCA==', 'Manage'),
(21, 'yashi ', '8zLRrrhyeaDlFVfEtO6OCA==', 'Manager'),
(22, 'JGTC', 'w/yGa6EVTSBi5S12qHxyoQ==', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `vouchers`
--

CREATE TABLE `vouchers` (
  `Vouch_ID` int(11) NOT NULL,
  `Type` varchar(20) NOT NULL,
  `Date` varchar(30) NOT NULL,
  `Entry Ledger` varchar(20) NOT NULL,
  `PartyLedger` varchar(30) NOT NULL,
  `amount` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `vouchers`
--

INSERT INTO `vouchers` (`Vouch_ID`, `Type`, `Date`, `Entry Ledger`, `PartyLedger`, `amount`) VALUES
(3, 'PURCHASE', '17-11-2020', 'Purchase a/c', 'M/s Rakesh', '600'),
(4, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Ishan&co', '600'),
(5, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Jirety', '3000'),
(6, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '1200'),
(7, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '1800'),
(8, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '600'),
(9, 'PURCHASE', '18-11-2020', '', '', ''),
(10, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '1200'),
(11, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '1200'),
(12, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '900'),
(13, 'PURCHASE', '18-11-2020', '', '', '1200'),
(14, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '1200'),
(15, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Jirety', '1200'),
(16, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Jirety', '6000'),
(17, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Ishan&co', '4800'),
(18, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Ishan&co', '1000'),
(19, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Ishan&co', '600'),
(20, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '1500'),
(21, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Ishan&co', '1200'),
(22, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '1200'),
(23, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '1200'),
(24, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '1200'),
(25, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '1200'),
(26, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '1200'),
(27, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '1200'),
(28, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '180'),
(29, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '1200'),
(30, 'PURCHASE', '18-11-2020', 'Purchase a/c', 'M/s Rakesh', '1800'),
(31, 'PURCHASE', '19-11-2020', '', '', '1200'),
(32, 'PURCHASE', '19-11-2020', 'purchasea/c', 'IshanJirety', '1200'),
(33, 'PURCHASE', '19-11-2020', 'purchasea/c', 'ManojTraders', '600'),
(34, 'PURCHASE', '19-11-2020', 'purchasea/c', 'ManojTraders', '1320'),
(35, 'PURCHASE', '19-11-2020', 'purchasea/c', 'ManojTraders', '1800'),
(36, 'PURCHASE', '19-11-2020', 'purchasea/c', 'm/s KishanTrading', '1200'),
(37, 'PURCHASE', '19-11-2020', 'purchasea/c', 'ishanRaiders', '1200'),
(38, 'PURCHASE', '19-11-2020', 'purchasea/c', 'obckjakhwda', '0'),
(39, 'PURCHASE', '19-11-2020', 'purchasea/c', 'ishanRaiders', '40'),
(40, 'PURCHASE', '19-11-2020', 'purchasea/c', 'IshanTraders', '1200'),
(41, 'PURCHASE', '20-11-2020', 'purchasea/c', 'ishanRaiders', '1200'),
(42, 'PURCHASE', '20-11-2020', 'purchasea/c', 'obckjakhwda', '1200'),
(43, 'PURCHASE', '21-11-2020', 'purchasea/c', 'M/s Rakesh', '1800'),
(44, 'PURCHASE', '21-11-2020', 'purchasea/c', 'M/s Ishan&co', '600'),
(45, 'PURCHASE', '21-11-2020', 'purchasea/c', 'M/s Jirety', '600'),
(46, 'PURCHASE', '21-11-2020', 'purchasea/c', 'obckjakhwda', '600'),
(47, 'PURCHASE', '21-11-2020', 'purchasea/c', 'M/s Ishan&co', '600'),
(48, 'PURCHASE', '21-11-2020', 'purchasea/c', 'M/s Ishan&co', '60'),
(49, 'PURCHASE', '21-11-2020', 'purchasea/c', 'M/s Rakesh', '600'),
(50, 'PURCHASE', '21-11-2020', 'purchasea/c', 'ManojTraders', '600'),
(51, 'PURCHASE', '21-11-2020', 'purchasea/c', 'obckjakhwda', '1200'),
(52, 'PURCHASE', '21-11-2020', 'purchasea/c', 'obckjakhwda', '600'),
(53, 'PURCHASE', '21-11-2020', 'purchasea/c', 'M/s Ishan&co', '1500'),
(54, 'PURCHASE', '22-11-2020', 'purchasea/c', '', '1200'),
(55, 'PURCHASE', '22-11-2020', 'salesa/c', 'M/s Jirety', '2800'),
(56, 'SALES', '22-11-2020', 'salesa/c', 'M/s Jirety', '1500'),
(57, 'SALES', '22-11-2020', 'salesa/c', 'M/s Jirety', '1200'),
(58, 'SALES', '22-11-2020', 'salesa/c', 'M/s Ishan&co', '600'),
(59, 'SALES', '22-11-2020', 'salesa/c', 'M/s Ishan&co', '120'),
(60, 'PURCHASE', '22-11-2020', 'purchasea/c', 'CashBook', '1200'),
(61, 'PURCHASE', '22-11-2020', 'purchasea/c', 'sabziBazar', '1200'),
(62, 'PURCHASE', '22-11-2020', 'purchasea/c', 'sabziBazar', '600'),
(63, 'PURCHASE', '23-11-2020', 'purchasea/c', 'sabziBazar', '1200'),
(64, 'SALES', '23-11-2020', 'salesa/c', 'rajkumar jirety', '6000'),
(65, 'SALES', '23-11-2020', 'salesa/c', 'rajkumar jirety', '2400'),
(66, 'SALES', '23-11-2020', 'salesa/c', 'rajkumar jirety', '2400'),
(67, 'SALES', '23-11-2020', 'salesa/c', 'rajkumar jirety', '5700'),
(68, 'SALES', '23-11-2020', 'salesa/c', 'rajkumar jirety', '5400'),
(69, 'SALES', '23-11-2020', 'salesa/c', 'RK Jirety', '1280'),
(70, 'SALES', '24-11-2020', 'salesa/c', 'RK Jirety', '6000'),
(71, 'SALES', '24-11-2020', 'salesa/c', 'RK Jirety', '12000'),
(72, 'SALES', '24-11-2020', 'salesa/c', 'RK Jirety', '1200'),
(73, 'SALES', '24-11-2020', 'salesa/c', 'RK Jirety', '2400'),
(74, 'SALES', '24-11-2020', 'salesa/c', 'RK Jirety', '1200'),
(75, 'SALES', '24-11-2020', 'salesa/c', 'RK Jirety', '24000'),
(76, 'SALES', '24-11-2020', 'salesa/c', 'RK Jirety', '600'),
(77, 'SALES', '24-11-2020', 'salesa/c', 'RK Jirety', '600'),
(78, 'SALES', '24-11-2020', 'salesa/c', 'RK Jirety', '600'),
(79, 'SALES', '24-11-2020', 'salesa/c', 'RK Jirety', '1200'),
(80, 'SALES', '24-11-2020', 'salesa/c', 'rajkumar jirety', '600'),
(81, 'SALES', '25-11-2020', 'salesa/c', 'RK Jirety', '6000'),
(82, 'SALES', '25-11-2020', 'salesa/c', 'RKJI', '1500'),
(83, 'SALES', '25-11-2020', 'salesa/c', 'RKJI', '1200'),
(84, 'SALES', '25-11-2021', 'salesa/c', 'RK Jirety', '1200'),
(85, 'PURCHASE', '25-11-2021', 'purchasea/c', 'sabziBazar', '600'),
(86, 'SALES', '26-11-2020', 'salesa/c', 'CashBook', '1200'),
(87, 'PURCHASE', '26-11-2020', 'purchasea/c', 'sabziBazar', '2400'),
(88, 'SALES', '27-11-2020', 'salesa/c', 'RK Jirety', '600'),
(89, 'PURCHASE', '29-11-2020', 'purchasea/c', 'sabziBazar', '3600'),
(90, 'PURCHASE', '29-11-2022', 'purchasea/c', 'sabziBazar', '1200'),
(91, 'SALES', '29-11-2022', 'salesa/c', 'RK Jirety', '2400'),
(92, 'SALES', '29-11-2022', 'salesa/c', 'CashBook', '1200'),
(93, 'SALES', '29-11-2023', 'salesa/c', 'CashBook', '3600'),
(94, 'PURCHASE', '02-12-2020', 'purchasea/c', 'sabziBazar', '3500'),
(95, 'SALES', '02-12-2020', 'salesa/c', 'RKJI', '14000'),
(96, 'SALES', '08-12-2020', 'salesa/c', 'RKJI', '200');

-- --------------------------------------------------------

--
-- Table structure for table `yearended`
--

CREATE TABLE `yearended` (
  `yr_id` int(11) NOT NULL,
  `YearEndDate` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `yearended`
--

INSERT INTO `yearended` (`yr_id`, `YearEndDate`) VALUES
(44, '2020'),
(46, '2021');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `challan`
--
ALTER TABLE `challan`
  ADD PRIMARY KEY (`challan_id`);

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`inv_id`);

--
-- Indexes for table `ledgernames`
--
ALTER TABLE `ledgernames`
  ADD PRIMARY KEY (`LedNumber`);

--
-- Indexes for table `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`log_ID`);

--
-- Indexes for table `purchase`
--
ALTER TABLE `purchase`
  ADD PRIMARY KEY (`PurchaseID`);

--
-- Indexes for table `retail`
--
ALTER TABLE `retail`
  ADD PRIMARY KEY (`retail_id`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`SaleID`);

--
-- Indexes for table `userlogin`
--
ALTER TABLE `userlogin`
  ADD PRIMARY KEY (`usr_id`);

--
-- Indexes for table `vouchers`
--
ALTER TABLE `vouchers`
  ADD PRIMARY KEY (`Vouch_ID`);

--
-- Indexes for table `yearended`
--
ALTER TABLE `yearended`
  ADD PRIMARY KEY (`yr_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `challan`
--
ALTER TABLE `challan`
  MODIFY `challan_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `inv_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `ledgernames`
--
ALTER TABLE `ledgernames`
  MODIFY `LedNumber` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `logs`
--
ALTER TABLE `logs`
  MODIFY `log_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `purchase`
--
ALTER TABLE `purchase`
  MODIFY `PurchaseID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `retail`
--
ALTER TABLE `retail`
  MODIFY `retail_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `SaleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `userlogin`
--
ALTER TABLE `userlogin`
  MODIFY `usr_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `vouchers`
--
ALTER TABLE `vouchers`
  MODIFY `Vouch_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=97;

--
-- AUTO_INCREMENT for table `yearended`
--
ALTER TABLE `yearended`
  MODIFY `yr_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
