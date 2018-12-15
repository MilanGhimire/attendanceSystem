-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 15, 2018 at 04:43 PM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_student_attendance`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_attendance`
--

CREATE TABLE `tbl_attendance` (
  `attendace_id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `teacher_id` int(11) NOT NULL,
  `section_id` int(11) NOT NULL,
  `subject_id` int(11) NOT NULL,
  `attendance_semester` int(11) NOT NULL,
  `attendance_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `attendance_status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_attendance`
--

INSERT INTO `tbl_attendance` (`attendace_id`, `student_id`, `teacher_id`, `section_id`, `subject_id`, `attendance_semester`, `attendance_date`, `attendance_status`) VALUES
(135, 41, 13, 1, 4, 1, '2018-12-07 05:17:24', 1),
(136, 42, 13, 1, 4, 1, '2018-12-07 05:17:24', 1),
(137, 43, 3, 2, 2, 1, '2018-12-07 05:17:24', 1),
(138, 44, 1, 2, 1, 1, '2018-12-07 05:17:24', 1),
(139, 45, 13, 3, 4, 1, '2018-12-07 05:17:24', 1),
(140, 46, 13, 4, 4, 1, '2018-12-07 05:17:24', 1),
(176, 41, 13, 1, 4, 1, '2018-12-07 06:58:24', 0),
(177, 42, 13, 1, 4, 1, '2018-12-07 06:58:24', 0),
(178, 43, 3, 2, 2, 1, '2018-12-07 06:58:24', 1),
(179, 44, 1, 2, 1, 1, '2018-12-07 06:58:24', 0),
(180, 45, 13, 3, 4, 1, '2018-12-07 06:58:24', 0),
(181, 46, 13, 4, 4, 1, '2018-12-07 06:58:24', 0),
(217, 41, 3, 1, 2, 1, '2018-12-07 07:55:59', 1),
(218, 42, 3, 1, 2, 1, '2018-12-07 07:55:59', 0),
(219, 43, 1, 2, 1, 1, '2018-12-07 07:55:59', 1),
(220, 44, 1, 2, 1, 1, '2018-12-07 07:55:59', 0),
(221, 45, 3, 3, 2, 1, '2018-12-07 07:55:59', 1),
(222, 46, 3, 4, 2, 1, '2018-12-07 07:55:59', 0),
(258, 41, 1, 1, 1, 5, '2018-12-07 07:56:31', 0),
(259, 42, 13, 1, 4, 5, '2018-12-07 07:56:31', 0),
(260, 43, 13, 2, 4, 1, '2018-12-07 07:56:31', 0),
(261, 44, 13, 2, 4, 1, '2018-12-07 07:56:31', 0),
(262, 45, 3, 3, 2, 1, '2018-12-07 07:56:31', 0),
(263, 46, 3, 4, 2, 5, '2018-12-07 07:56:31', 0),
(338, 41, 1, 1, 1, 1, '2018-12-07 17:01:35', 1),
(339, 42, 3, 1, 2, 1, '2018-12-07 17:01:35', 1),
(340, 43, 1, 2, 1, 1, '2018-12-07 17:01:35', 0),
(341, 44, 1, 2, 1, 1, '2018-12-07 17:01:35', 0),
(342, 45, 13, 3, 4, 1, '2018-12-07 17:01:35', 1),
(343, 46, 13, 4, 4, 1, '2018-12-07 17:01:35', 0),
(379, 41, 1, 1, 1, 1, '2018-12-07 17:47:46', 1),
(380, 42, 1, 1, 1, 1, '2018-12-07 17:47:46', 1),
(381, 43, 13, 2, 4, 1, '2018-12-07 17:47:46', 1),
(382, 44, 13, 2, 4, 1, '2018-12-07 17:47:46', 1),
(383, 45, 13, 3, 4, 1, '2018-12-07 17:47:46', 1),
(384, 46, 1, 4, 1, 1, '2018-12-07 17:47:46', 1),
(420, 41, 1, 1, 1, 1, '2018-12-07 19:31:30', 1),
(421, 42, 1, 1, 1, 1, '2018-12-07 19:31:30', 1),
(422, 43, 3, 2, 2, 1, '2018-12-07 19:31:30', 1),
(423, 44, 3, 2, 2, 1, '2018-12-07 19:31:30', 1),
(424, 45, 13, 3, 4, 1, '2018-12-07 19:31:30', 1),
(425, 46, 3, 4, 2, 1, '2018-12-07 19:31:30', 1),
(461, 41, 1, 1, 1, 1, '2018-12-07 19:35:17', 1),
(462, 42, 3, 1, 2, 1, '2018-12-07 19:35:18', 0),
(463, 43, 13, 2, 4, 1, '2018-12-07 19:35:18', 1),
(464, 44, 3, 2, 2, 1, '2018-12-07 19:35:18', 1),
(465, 45, 1, 3, 1, 1, '2018-12-07 19:35:18', 1),
(466, 46, 3, 4, 2, 1, '2018-12-07 19:35:19', 1),
(471, 41, 3, 1, 2, 1, '2018-12-07 19:35:20', 1),
(473, 42, 3, 1, 2, 1, '2018-12-07 19:35:20', 0),
(475, 43, 3, 2, 2, 1, '2018-12-07 19:35:21', 1),
(477, 44, 13, 2, 4, 1, '2018-12-07 19:35:21', 1),
(479, 45, 3, 3, 2, 1, '2018-12-07 19:35:21', 1),
(481, 46, 13, 4, 4, 1, '2018-12-07 19:35:21', 1),
(544, 41, 1, 1, 1, 1, '2018-12-07 19:44:22', 0),
(545, 42, 13, 1, 4, 1, '2018-12-07 19:44:22', 1),
(546, 43, 13, 2, 4, 1, '2018-12-07 19:44:22', 0),
(547, 44, 3, 2, 2, 1, '2018-12-07 19:44:22', 0),
(548, 45, 1, 3, 1, 1, '2018-12-07 19:44:22', 0),
(549, 46, 13, 4, 4, 1, '2018-12-07 19:44:22', 0),
(585, 41, 13, 1, 4, 1, '2018-12-07 19:46:49', 1),
(586, 42, 1, 1, 1, 1, '2018-12-07 19:46:49', 1),
(587, 43, 3, 2, 2, 1, '2018-12-07 19:46:49', 1),
(588, 44, 13, 2, 4, 1, '2018-12-07 19:46:49', 1),
(589, 45, 1, 3, 1, 1, '2018-12-07 19:46:49', 1),
(590, 46, 13, 4, 4, 1, '2018-12-07 19:46:49', 1),
(626, 41, 3, 1, 2, 1, '2018-12-07 19:49:43', 0),
(627, 42, 13, 1, 4, 1, '2018-12-07 19:49:43', 0),
(628, 43, 1, 2, 1, 1, '2018-12-07 19:49:43', 0),
(629, 44, 1, 2, 1, 1, '2018-12-07 19:49:43', 0),
(630, 45, 3, 3, 2, 1, '2018-12-07 19:49:43', 0),
(631, 46, 3, 4, 2, 1, '2018-12-07 19:49:43', 0),
(667, 41, 1, 1, 1, 1, '2018-12-07 20:21:34', 0),
(668, 42, 1, 1, 1, 1, '2018-12-07 20:21:35', 0),
(669, 43, 13, 2, 4, 1, '2018-12-07 20:21:35', 0),
(670, 44, 13, 2, 4, 1, '2018-12-07 20:21:35', 0),
(671, 45, 13, 3, 4, 1, '2018-12-07 20:21:35', 0),
(672, 46, 1, 4, 1, 1, '2018-12-07 20:21:35', 0),
(708, 41, 13, 1, 4, 1, '2018-12-07 20:21:37', 0),
(709, 42, 1, 1, 1, 1, '2018-12-07 20:21:37', 0),
(710, 43, 13, 2, 4, 1, '2018-12-07 20:21:37', 0),
(711, 44, 13, 2, 4, 1, '2018-12-07 20:21:37', 0),
(712, 45, 3, 3, 2, 1, '2018-12-07 20:21:37', 0),
(713, 46, 3, 4, 2, 1, '2018-12-07 20:21:37', 0),
(746, 41, 1, 1, 1, 1, '2018-12-07 20:21:39', 0),
(748, 42, 1, 1, 1, 1, '2018-12-07 20:21:40', 0),
(750, 43, 3, 2, 2, 1, '2018-12-07 20:21:40', 0),
(752, 44, 13, 2, 4, 1, '2018-12-07 20:21:40', 0),
(753, 45, 1, 3, 1, 1, '2018-12-07 20:21:40', 0),
(754, 46, 13, 4, 4, 1, '2018-12-07 20:21:40', 0),
(792, 44, 13, 2, 4, 1, '2018-12-12 16:19:22', 1),
(793, 44, 1, 2, 1, 1, '2018-12-12 16:19:22', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_department`
--

CREATE TABLE `tbl_department` (
  `dept_id` int(11) NOT NULL,
  `dept_name` varchar(250) NOT NULL,
  `gradutaion_type` enum('Year','Semester') NOT NULL,
  `course_duration` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_department`
--

INSERT INTO `tbl_department` (`dept_id`, `dept_name`, `gradutaion_type`, `course_duration`) VALUES
(1, 'BIT', 'Semester', 8),
(2, 'Baa', 'Year', 5),
(3, 'BBS', 'Year', 4),
(4, 'BBS', 'Year', 4),
(5, 'BBA', 'Semester', 8);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_section`
--

CREATE TABLE `tbl_section` (
  `sec_id` int(11) NOT NULL,
  `dept_id` int(11) NOT NULL,
  `sec_name` varchar(250) NOT NULL,
  `teacher_id` int(11) NOT NULL,
  `sem_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_section`
--

INSERT INTO `tbl_section` (`sec_id`, `dept_id`, `sec_name`, `teacher_id`, `sem_id`) VALUES
(1, 1, 'Section A', 1, 1),
(2, 1, 'Section B', 1, 1),
(3, 1, 'Section C', 1, 1),
(4, 1, 'Section D', 1, 1),
(5, 1, 'Section A', 0, 2),
(6, 1, 'Section B', 0, 2),
(7, 1, 'Section C', 0, 2),
(8, 1, 'Section D', 0, 2),
(9, 1, 'Section E', 0, 2),
(10, 1, 'Section F', 0, 2);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_semester`
--

CREATE TABLE `tbl_semester` (
  `sem_id` int(11) NOT NULL,
  `dept_id` int(11) NOT NULL,
  `sem_name` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_semester`
--

INSERT INTO `tbl_semester` (`sem_id`, `dept_id`, `sem_name`) VALUES
(1, 1, 'First'),
(2, 1, 'Second');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_student`
--

CREATE TABLE `tbl_student` (
  `student_id` int(11) NOT NULL,
  `dept_id` int(11) NOT NULL,
  `sem_id` int(3) NOT NULL,
  `sec_id` int(11) NOT NULL,
  `student_name` varchar(90) NOT NULL,
  `student_card_id` int(11) NOT NULL,
  `student_contact` varchar(10) DEFAULT NULL,
  `parents_contact` varchar(10) DEFAULT NULL,
  `student_address` varchar(90) DEFAULT NULL,
  `student_email` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_student`
--

INSERT INTO `tbl_student` (`student_id`, `dept_id`, `sem_id`, `sec_id`, `student_name`, `student_card_id`, `student_contact`, `parents_contact`, `student_address`, `student_email`) VALUES
(2, 1, 3, 0, 'Anil Shrestha', 0, '9849627149', '9808189745', 'ktm', 'something@gmail.com'),
(3, 1, 3, 0, 'Anisha Rauniyar', 0, '9818544722', '9823319800', 'ktm', 'something@gmail.com'),
(4, 1, 3, 0, 'Ashish Bhasima', 0, '9813743112', '9841384094', 'ktm', 'something@gmail.com'),
(5, 1, 3, 0, 'Bibek Lamichhane', 0, '9845675869', '9845056814', 'ktm', 'something@gmail.com'),
(6, 1, 3, 0, 'Bijaya Karki', 0, '9867621052', '9847662905', 'ktm', 'something@gmail.com'),
(7, 1, 3, 0, 'Bilson Naya', 0, '9803058815', '9851160173', 'ktm', 'something@gmail.com'),
(8, 1, 3, 0, 'Binod Dangal', 0, '9860098323', '9841964303', 'ktm', 'something@gmail.com'),
(9, 1, 3, 0, 'Charchit Khadka', 0, '9862242506', '9844152080', 'ktm', 'something@gmail.com'),
(10, 1, 3, 0, 'Danish Alam', 0, '9862131749', '9851193835', 'ktm', 'something@gmail.com'),
(11, 1, 3, 0, 'Gyanendra Kumal', 0, '9860976881', '9849541369', 'ktm', 'something@gmail.com'),
(12, 1, 3, 0, 'Hamlet Maharjan', 0, '9841363126', '9849873145', 'ktm', 'something@gmail.com'),
(13, 1, 3, 0, 'Keshab Bhandel', 0, '9808012565', '9860437472', 'ktm', 'something@gmail.com'),
(14, 1, 3, 0, 'Kunjan Rajbhandari', 0, '9819087207', '', 'ktm', 'something@gmail.com'),
(15, 1, 3, 0, 'Manoj Poudel', 0, '9860226925', '9867259703', 'ktm', 'something@gmail.com'),
(16, 1, 3, 0, 'Payal Singh Chauhan', 0, '9808253676', '9843255574', 'ktm', 'something@gmail.com'),
(17, 1, 3, 0, 'Punya Ram Duwal', 0, '9860291678', '9841477342', 'ktm', 'something@gmail.com'),
(18, 1, 3, 0, 'Reeya Sthapit', 0, '9808081551', '9841957288', 'ktm', 'something@gmail.com'),
(19, 1, 3, 0, 'Roshan Lasiwa', 0, '9860117662', '9849175838', 'ktm', 'something@gmail.com'),
(20, 1, 3, 0, 'Roshan Shrestha', 0, '9845483935', '9851008297', 'ktm', 'something@gmail.com'),
(21, 1, 3, 0, 'Roshan Shrestha', 0, '9810497636', '', 'ktm', 'something@gmail.com'),
(22, 1, 3, 0, 'Rukesh Basukala', 0, '9813345559', '9849989267', 'ktm', 'something@gmail.com'),
(23, 1, 3, 0, 'Sadikshya Shrestha', 0, '9861185905', '9808323399', 'ktm', 'something@gmail.com'),
(24, 1, 3, 0, 'Sagar Neupane', 0, '9860924236', '', 'ktm', 'something@gmail.com'),
(25, 1, 3, 0, 'Sajan Chakradhar', 0, '9818392521', '9841245302', 'ktm', 'something@gmail.com'),
(26, 1, 3, 0, 'Sandesh Shrestha', 0, '9841505813', '9843338421', 'ktm', 'something@gmail.com'),
(27, 1, 3, 0, 'SantoshNeupane', 0, '9846727101', '9846755615', 'ktm', 'something@gmail.com'),
(28, 1, 3, 0, 'Saugat Singh Thakuri', 0, '9860297115', '9841907181', 'ktm', 'something@gmail.com'),
(29, 1, 3, 0, 'Sayara Dangol', 0, '9860165321', '9803841202', 'ktm', 'something@gmail.com'),
(30, 1, 3, 0, 'Shankar Shrestha', 0, '9860080243', '9808065018', 'ktm', 'something@gmail.com'),
(31, 1, 3, 0, 'Smarika Rijal', 0, '9861293048', '9849070503', 'ktm', 'something@gmail.com'),
(32, 1, 3, 0, 'Souraj Khadka', 0, '9810059054', '', 'ktm', 'something@gmail.com'),
(33, 1, 3, 0, 'Subin Shrestha', 0, '9860023906', '9841309239', 'ktm', 'something@gmail.com'),
(34, 1, 3, 0, 'Sumit Bhattarai', 0, '9823763214', '9841329955', 'ktm', 'something@gmail.com'),
(35, 1, 3, 0, 'Susan Koju', 0, '9813651008', '9841403077', 'ktm', 'something@gmail.com'),
(36, 1, 3, 0, 'Sushan Shrestha', 0, '9841393628', '9841393628', 'ktm', 'something@gmail.com'),
(37, 1, 3, 0, 'Sushan Sitikhu', 0, '9841349429', '9841349429', 'ktm', 'something@gmail.com'),
(38, 1, 3, 0, 'Sushant Shrestha', 0, '9861346363', '9845303830', 'ktm', 'something@gmail.com'),
(39, 1, 3, 0, 'Swastik Thapaliya', 0, '9818611436', '9841295267', 'ktm', 'something@gmail.com'),
(40, 1, 3, 0, 'Tirtha Raj Neupane', 0, '9844776527', '9857040363', 'ktm', 'something@gmail.com'),
(41, 1, 1, 0, 'AANSH KUMAR YADAV', 0, '9818449285', '9845831428', 'ktm', 'something@gmail.com'),
(42, 1, 1, 0, 'AAYUSHMA REGMI', 0, '9869162415', '9841362621', 'ktm', 'something@gmail.com'),
(43, 1, 1, 0, 'AMIR RAJ REGMI', 0, '9823404446', '9851044848', 'ktm', 'something@gmail.com'),
(44, 1, 1, 0, 'ANISH KUNWAR', 1502, '9841661952', '9811111111', 'ktm', 'something@gmail.com'),
(45, 1, 1, 0, 'BHIM RAJ SAHI', 0, '9813251722', '9848308644', 'ktm', 'something@gmail.com'),
(46, 1, 1, 0, 'BIBEK BIKRAM SHARE', 0, '9861388377', '9869277137', 'ktm', 'something@gmail.com'),
(47, 1, 1, 0, 'BIJEN SHRESTHA', 0, '9849827976', '9810178340', 'ktm', 'something@gmail.com'),
(48, 1, 1, 0, 'BIMAL KAFLE', 0, '9861845940', '9741151148', 'ktm', 'something@gmail.com'),
(49, 1, 1, 0, 'BISHAKHA PRADHAN', 0, '9811111111', '9742026966', 'ktm', 'something@gmail.com'),
(50, 1, 1, 0, 'BISHAL KHATRI', 0, '9840144477', '9841947768', 'ktm', 'something@gmail.com'),
(51, 1, 1, 0, 'BIVEK JUNG PANDEY', 0, '9843629900', '9851148093', 'ktm', 'something@gmail.com'),
(52, 1, 1, 0, 'DIWASH KUMAR POUDEL', 0, '9860907070', '9841929247', 'ktm', 'something@gmail.com'),
(53, 1, 1, 0, 'HIMSHIKHA BHANDARI', 0, '9814707155', '9824737377', 'ktm', 'something@gmail.com'),
(54, 1, 1, 0, 'ISHAN MANNDHAR', 0, '9840456062', '9841251691', 'ktm', 'something@gmail.com'),
(55, 1, 1, 0, 'JAYANT SAPKOTA', 0, '9810478262', '9852645000', 'ktm', 'something@gmail.com'),
(56, 1, 1, 0, 'KAILASH TAMANG', 0, '9841389951', '9841264925', 'ktm', 'something@gmail.com'),
(57, 1, 1, 0, 'KSHITIZ GC', 0, '9816409419', '9822872422', 'ktm', 'something@gmail.com'),
(58, 1, 1, 0, 'MANORAM SUBEDI', 0, '9827120888', '9846026094', 'ktm', 'something@gmail.com'),
(59, 1, 1, 0, 'MARSHAL CHAUHAN', 0, '9862843952', '9861765129', 'ktm', 'something@gmail.com'),
(60, 1, 1, 0, 'MD SAMSAD ALI', 0, '9813381892', '9807782356', 'ktm', 'something@gmail.com'),
(61, 1, 1, 0, 'MUKESH RAJBHANDARI', 0, '9861692966', '9862805213', 'ktm', 'something@gmail.com'),
(62, 1, 1, 0, 'PETER RAI', 0, '9860307316', '9861873132', 'ktm', 'something@gmail.com'),
(63, 1, 1, 0, 'PRABIN THAOA MAGAR', 0, '9818951799', '9860528028', 'ktm', 'something@gmail.com'),
(64, 1, 1, 0, 'PREET BISTA', 0, '9813811008', '9849051171', 'ktm', 'something@gmail.com'),
(65, 1, 1, 0, 'PRINCE KHADGI', 0, '9808179286', '9841703485', 'ktm', 'something@gmail.com'),
(66, 1, 1, 0, 'RIMSHA SHRESTHA', 0, '9811111111', '9811111111', 'ktm', 'something@gmail.com'),
(67, 1, 1, 0, 'ROHIT MANANDHAR', 0, '9860149078', '9841955628', 'ktm', 'something@gmail.com'),
(68, 1, 1, 0, 'SAKSHI NAKARMI', 0, '9823108870', '9801173811', 'ktm', 'something@gmail.com'),
(69, 1, 1, 0, 'SANDESH SINGH MAHARJAN', 0, '9861329848', '9849995633', 'ktm', 'something@gmail.com'),
(70, 1, 1, 0, 'SANDHYA PHUYAL', 0, '9869416100', '9803023954', 'ktm', 'something@gmail.com'),
(71, 1, 1, 0, 'SANDHYA GYAWALI', 0, '9866230330', '9858030606', 'ktm', 'something@gmail.com'),
(72, 1, 1, 0, 'SAROJ ADHIKARI', 0, '9825953356', '9842787425', 'ktm', 'something@gmail.com'),
(73, 1, 1, 0, 'SAROJ SHRESTHA', 0, '9823503362', '9803414176', 'ktm', 'something@gmail.com'),
(74, 1, 1, 0, 'SAROJ ADHIKARI NEPAL', 0, '9868754257', '9841516770', 'ktm', 'something@gmail.com'),
(75, 1, 1, 0, 'SAROJ RAI', 0, '9818304857', '9751003847', 'ktm', 'something@gmail.com'),
(76, 1, 1, 0, 'SHAMEE BAJRACHARYA', 0, '9849792399', '9841365022', 'ktm', 'something@gmail.com'),
(77, 1, 1, 0, 'SUNIL BK', 0, '9813253082', '9861062365', 'ktm', 'something@gmail.com'),
(78, 1, 1, 0, 'SUSHANT MANANDHAR', 0, '9861293394', '9843027784', 'ktm', 'something@gmail.com'),
(79, 1, 1, 0, 'SUSHMA ADHIKARI', 0, '9840269376', '9843293982', 'ktm', 'something@gmail.com'),
(80, 1, 1, 0, 'SUVEKSHYA  KHADKA', 0, '9811111111', '9811111111', 'ktm', 'something@gmail.com'),
(81, 1, 1, 0, 'jfhccfh', 0, '868689', '868689', 'gg', 'tdjh'),
(82, 1, 6, 0, 'ram', 0, '969699699', '969699699', 'trggh', 'thhgxdg'),
(83, 1, 7, 0, 'MD Faijan', 0, '9808556045', '9808556045', 'Chabahil', 'md.faijan@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_subject`
--

CREATE TABLE `tbl_subject` (
  `subject_id` int(11) NOT NULL,
  `subject_department` int(11) NOT NULL,
  `subject_semester` int(11) NOT NULL,
  `subject_teacher` int(11) NOT NULL,
  `subject_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_subject`
--

INSERT INTO `tbl_subject` (`subject_id`, `subject_department`, `subject_semester`, `subject_teacher`, `subject_name`) VALUES
(1, 1, 7, 4, 'java'),
(2, 1, 7, 3, 'PHP'),
(3, 1, 1, 3, 'CS'),
(4, 1, 1, 1, 'Math'),
(5, 1, 2, 1, 'Math-II');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_teacher`
--

CREATE TABLE `tbl_teacher` (
  `teacher_id` int(11) NOT NULL,
  `teacher_name` varchar(90) NOT NULL,
  `teacher_contact` bigint(10) NOT NULL,
  `teacher_address` varchar(90) NOT NULL,
  `teacher_email` varchar(45) NOT NULL,
  `dept_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_teacher`
--

INSERT INTO `tbl_teacher` (`teacher_id`, `teacher_name`, `teacher_contact`, `teacher_address`, `teacher_email`, `dept_id`) VALUES
(1, 'batman', 9843661414, 'gotham', 'umeshchakradhar11@gmail.com', 1),
(2, 'umesh', 9843661414, 'bhaktapur', 'umeshchakradhar11@gmail.com', 1),
(3, 'Ronaldo', 9846325145, 'Turin', 'cronaldo28@gmail.com', 1),
(4, 'spiderman', 9876541425, 'thimi', 'spidey28@gmail.com', 0),
(5, 'ram', 8798797887, 'asjdaskjd', 'ram@gmail.com', 0),
(6, 'ram', 8798797887, 'asjdaskjd', 'ram@gmail.com', 0),
(7, 'ram', 8798797887, 'asjdaskjd', 'ram@gmail.com', 0),
(8, 'ram', 8798797887, 'asjdaskjd', 'ram@gmail.com', 0),
(9, 'ram', 8798797887, 'asjdaskjd', 'ram@gmail.com', 0),
(10, 'ram', 8798797887, 'asjdaskjd', 'ram@gmail.com', 0),
(11, 'ram', 8798797887, 'asjdaskjd', 'ram@gmail.com', 0),
(12, 'hshahs', 0, 'ahajaja', 'jsjsnwnwnns', 0),
(13, 'Umesh', 0, 'Bhaktapur', 'umesh@gmail.com', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user_account`
--

CREATE TABLE `tbl_user_account` (
  `ua_id` int(11) NOT NULL,
  `ua_username` varchar(40) NOT NULL,
  `ua_password` varchar(60) NOT NULL,
  `ua_role` varchar(10) NOT NULL,
  `ua_department_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_user_account`
--

INSERT INTO `tbl_user_account` (`ua_id`, `ua_username`, `ua_password`, `ua_role`, `ua_department_id`) VALUES
(1, 'milan', 'milan', '1', 1),
(2, 'umesh', 'umesh', '1', 1),
(3, 'fijan', 'fijan', '1', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_attendance`
--
ALTER TABLE `tbl_attendance`
  ADD PRIMARY KEY (`attendace_id`);

--
-- Indexes for table `tbl_department`
--
ALTER TABLE `tbl_department`
  ADD PRIMARY KEY (`dept_id`);

--
-- Indexes for table `tbl_section`
--
ALTER TABLE `tbl_section`
  ADD PRIMARY KEY (`sec_id`);

--
-- Indexes for table `tbl_semester`
--
ALTER TABLE `tbl_semester`
  ADD PRIMARY KEY (`sem_id`);

--
-- Indexes for table `tbl_student`
--
ALTER TABLE `tbl_student`
  ADD PRIMARY KEY (`student_id`);

--
-- Indexes for table `tbl_subject`
--
ALTER TABLE `tbl_subject`
  ADD PRIMARY KEY (`subject_id`);

--
-- Indexes for table `tbl_teacher`
--
ALTER TABLE `tbl_teacher`
  ADD PRIMARY KEY (`teacher_id`);

--
-- Indexes for table `tbl_user_account`
--
ALTER TABLE `tbl_user_account`
  ADD PRIMARY KEY (`ua_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_attendance`
--
ALTER TABLE `tbl_attendance`
  MODIFY `attendace_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=794;

--
-- AUTO_INCREMENT for table `tbl_department`
--
ALTER TABLE `tbl_department`
  MODIFY `dept_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_section`
--
ALTER TABLE `tbl_section`
  MODIFY `sec_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tbl_semester`
--
ALTER TABLE `tbl_semester`
  MODIFY `sem_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_student`
--
ALTER TABLE `tbl_student`
  MODIFY `student_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=84;

--
-- AUTO_INCREMENT for table `tbl_subject`
--
ALTER TABLE `tbl_subject`
  MODIFY `subject_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_teacher`
--
ALTER TABLE `tbl_teacher`
  MODIFY `teacher_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tbl_user_account`
--
ALTER TABLE `tbl_user_account`
  MODIFY `ua_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
