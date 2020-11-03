/*
 Navicat Premium Data Transfer

 Source Server         : localhost_3306
 Source Server Type    : MySQL
 Source Server Version : 50729
 Source Host           : localhost:3306
 Source Schema         : c#_store

 Target Server Type    : MySQL
 Target Server Version : 50729
 File Encoding         : 65001

 Date: 03/11/2020 09:25:40
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for manu
-- ----------------------------
DROP TABLE IF EXISTS `manu`;
CREATE TABLE `manu`  (
  `manu_id` int(11) NOT NULL AUTO_INCREMENT,
  `manu_shop_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `manu_shop_price` decimal(10, 2) NULL DEFAULT NULL,
  `manu_shop_number` int(11) NULL DEFAULT NULL,
  `manu_re_person` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `manu_re_phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `manu_re_address` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `manu_data` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `manu_out_user` int(255) NULL DEFAULT NULL,
  PRIMARY KEY (`manu_id`) USING BTREE,
  INDEX `manu_out_user`(`manu_out_user`) USING BTREE,
  CONSTRAINT `manu_ibfk_1` FOREIGN KEY (`manu_out_user`) REFERENCES `user_supplier` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for outbound
-- ----------------------------
DROP TABLE IF EXISTS `outbound`;
CREATE TABLE `outbound`  (
  `outbound_id` int(11) NOT NULL AUTO_INCREMENT,
  `outbound_shop_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `outbound_shop_price` decimal(10, 2) NULL DEFAULT NULL,
  `outbound_shop_number` int(11) NULL DEFAULT NULL,
  `outbound_to_person` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `outbound_to_phone` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `outbound_to_address` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `outbound_data` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `out_user_id` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`outbound_id`) USING BTREE,
  INDEX `out_user_id`(`out_user_id`) USING BTREE,
  CONSTRAINT `outbound_ibfk_1` FOREIGN KEY (`out_user_id`) REFERENCES `user_customer` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 11 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of outbound
-- ----------------------------
INSERT INTO `outbound` VALUES (10, '上海', 12.00, 1000, '2', '1', '2', '2020/11/2 0:24:19', 4);

-- ----------------------------
-- Table structure for stock_store
-- ----------------------------
DROP TABLE IF EXISTS `stock_store`;
CREATE TABLE `stock_store`  (
  `stock_id` int(11) NOT NULL AUTO_INCREMENT,
  `stock_shop_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `stock_shop_price` decimal(10, 2) NULL DEFAULT NULL,
  `stock_shop_number` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`stock_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 7 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of stock_store
-- ----------------------------
INSERT INTO `stock_store` VALUES (1, '青岛', 12.00, 66);
INSERT INTO `stock_store` VALUES (2, '上海', 11.00, 1);
INSERT INTO `stock_store` VALUES (5, '1', 11.00, 3);
INSERT INTO `stock_store` VALUES (6, '2', 112.00, 50);

-- ----------------------------
-- Table structure for stock_supplier
-- ----------------------------
DROP TABLE IF EXISTS `stock_supplier`;
CREATE TABLE `stock_supplier`  (
  `stock_supplier_id` int(11) NOT NULL AUTO_INCREMENT,
  `supplier_shop_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `supplier_shop_price` decimal(10, 2) NULL DEFAULT NULL,
  `supplier_shop_number` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`stock_supplier_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of stock_supplier
-- ----------------------------
INSERT INTO `stock_supplier` VALUES (1, '董文硕', 12.00, 1);

-- ----------------------------
-- Table structure for user_customer
-- ----------------------------
DROP TABLE IF EXISTS `user_customer`;
CREATE TABLE `user_customer`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 5 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of user_customer
-- ----------------------------
INSERT INTO `user_customer` VALUES (3, '和学博');
INSERT INTO `user_customer` VALUES (4, '赵瑞');

-- ----------------------------
-- Table structure for user_store
-- ----------------------------
DROP TABLE IF EXISTS `user_store`;
CREATE TABLE `user_store`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 7 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of user_store
-- ----------------------------
INSERT INTO `user_store` VALUES (1, '赵', '123');
INSERT INTO `user_store` VALUES (2, '青草', '123');
INSERT INTO `user_store` VALUES (3, '111', '1');
INSERT INTO `user_store` VALUES (4, '12345', '12');
INSERT INTO `user_store` VALUES (5, '123', '1');
INSERT INTO `user_store` VALUES (6, '1111', '1111');

-- ----------------------------
-- Table structure for user_supplier
-- ----------------------------
DROP TABLE IF EXISTS `user_supplier`;
CREATE TABLE `user_supplier`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
