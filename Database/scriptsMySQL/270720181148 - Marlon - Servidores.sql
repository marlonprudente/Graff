/*
Navicat MySQL Data Transfer

Source Server         : Rebelion
Source Server Version : 50723
Source Host           : localhost:3306
Source Database       : rebelion

Target Server Type    : MYSQL
Target Server Version : 50723
File Encoding         : 65001

Date: 2018-07-29 11:45:49
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `servidor`
-- ----------------------------
CREATE TABLE `Empresa` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(255) NOT NULL,
  `URL` varchar(255) DEFAULT NULL,
  `Jogo` varchar(255) NOT NULL,
  `JogoVersao` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of servidor
-- ----------------------------
INSERT INTO `Empresa` VALUES ('1', 'Rebelion', 'rebelionserver.com', 'Lineage2', 'Interlude');
