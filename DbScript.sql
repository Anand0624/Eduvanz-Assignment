CREATE DATABASE `assignment` /*!40100 DEFAULT CHARACTER SET utf8 */;

CREATE TABLE `tbl_meetup` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `dateofbirth` datetime DEFAULT NULL,
  `profession` varchar(45) DEFAULT NULL,
  `locality` varchar(100) DEFAULT NULL,
  `noofguest` int(11) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `createdon` datetime DEFAULT NULL,
  `updatedon` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
