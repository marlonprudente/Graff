/*
Navicat MySQL Data Transfer

Source Server         : Rebelion
Source Server Version : 50723
Source Host           : localhost:3306
Source Database       : leilao

Target Server Type    : MYSQL
Target Server Version : 50723
File Encoding         : 65001

Date: 2019-05-23 19:39:26
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `lances`
-- ----------------------------
DROP TABLE IF EXISTS `lances`;
CREATE TABLE `lances` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `UsuarioID` int(11) NOT NULL,
  `ProdutoID` int(11) NOT NULL,
  `Lance` decimal(10,0) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of lances
-- ----------------------------
INSERT INTO `lances` VALUES ('1', '1', '1', '21000');
INSERT INTO `lances` VALUES ('2', '1', '1', '21001');
INSERT INTO `lances` VALUES ('3', '1', '1', '21002');
INSERT INTO `lances` VALUES ('4', '1', '1', '21003');
INSERT INTO `lances` VALUES ('5', '3', '1', '21004');
INSERT INTO `lances` VALUES ('6', '1', '2', '8000');
INSERT INTO `lances` VALUES ('7', '2', '2', '9000');
INSERT INTO `lances` VALUES ('8', '1', '1', '21005');

-- ----------------------------
-- Table structure for `produtos`
-- ----------------------------
DROP TABLE IF EXISTS `produtos`;
CREATE TABLE `produtos` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` varchar(255) NOT NULL,
  `Valor` decimal(10,0) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of produtos
-- ----------------------------
INSERT INTO `produtos` VALUES ('1', 'Uno com escada em cima', '20000');
INSERT INTO `produtos` VALUES ('2', 'Moto Bross 160 CC', '8000');

-- ----------------------------
-- Table structure for `usuarios`
-- ----------------------------
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` varchar(255) NOT NULL,
  `senha` varchar(255) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of usuarios
-- ----------------------------
INSERT INTO `usuarios` VALUES ('1', 'marlonprudente', 'asdf');
INSERT INTO `usuarios` VALUES ('2', 'marlon2', '?% Z????5_??V?;?\'T??m?lq6??o');
INSERT INTO `usuarios` VALUES ('3', 'marlon2', '?% Z????5_??V?;?\'T??m?lq6??o');
INSERT INTO `usuarios` VALUES ('4', 'marlon3', '?\Z ???h??m????r??Wj???#??');
