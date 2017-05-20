/*
Navicat MySQL Data Transfer

Source Server         : Mysql
Source Server Version : 50617
Source Host           : 127.0.0.1:3306
Source Database       : distribuidora_el_buen_precio

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2017-03-31 16:00:06
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for categorias
-- ----------------------------
DROP TABLE IF EXISTS `categorias`;
CREATE TABLE `categorias` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) DEFAULT NULL,
  `descripción` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of categorias
-- ----------------------------
INSERT INTO `categorias` VALUES ('4', 'Granos básicos', 'Granos básicos');
INSERT INTO `categorias` VALUES ('5', 'Electrodomesticos', null);

-- ----------------------------
-- Table structure for compra_productos
-- ----------------------------
DROP TABLE IF EXISTS `compra_productos`;
CREATE TABLE `compra_productos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `emplado_id` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `inventario_id` int(11) DEFAULT NULL,
  `fecha_compra` datetime DEFAULT CURRENT_TIMESTAMP,
  `fecha_vencimiento` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `fk_entradas_inventario_inv_idx` (`inventario_id`),
  KEY `fk_empleado_compra_idx` (`emplado_id`),
  KEY `cantidad` (`cantidad`),
  CONSTRAINT `fk_compra_productos_inv` FOREIGN KEY (`inventario_id`) REFERENCES `inventario` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_empleado_compra` FOREIGN KEY (`emplado_id`) REFERENCES `emplados` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of compra_productos
-- ----------------------------
INSERT INTO `compra_productos` VALUES ('4', '1', '50000', '10', '2017-03-31 00:00:00', '2017-03-31 00:00:00');
INSERT INTO `compra_productos` VALUES ('5', '1', '6000000', '14', '2017-03-31 00:00:00', '2017-03-31 00:00:00');
INSERT INTO `compra_productos` VALUES ('6', '1', '99000000', '13', '2017-03-31 00:00:00', '2017-03-31 00:00:00');
INSERT INTO `compra_productos` VALUES ('7', '1', '99000000', '12', '2017-03-31 00:00:00', '2017-03-31 00:00:00');

-- ----------------------------
-- Table structure for distribuidora
-- ----------------------------
DROP TABLE IF EXISTS `distribuidora`;
CREATE TABLE `distribuidora` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of distribuidora
-- ----------------------------
INSERT INTO `distribuidora` VALUES ('1', 'Faisan');

-- ----------------------------
-- Table structure for emplados
-- ----------------------------
DROP TABLE IF EXISTS `emplados`;
CREATE TABLE `emplados` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `apellido` varchar(45) NOT NULL,
  `telefono` varchar(45) NOT NULL,
  `estado_civil` varchar(45) DEFAULT NULL,
  `dirección` varchar(45) NOT NULL,
  `fehca_ingreso` datetime DEFAULT CURRENT_TIMESTAMP,
  `fecha_baja` datetime DEFAULT NULL,
  PRIMARY KEY (`id`,`nombre`,`apellido`,`telefono`,`dirección`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of emplados
-- ----------------------------
INSERT INTO `emplados` VALUES ('1', '@nombre', '@apellido', '@tel', '@est_civ', '@dir', '2017-02-28 00:07:03', null);
INSERT INTO `emplados` VALUES ('2', '@nombre', '@apellido', '@tel', '@est_civ', '@dir', '2017-02-28 20:39:35', null);
INSERT INTO `emplados` VALUES ('3', 'Wilton', 'Centeno', '7777777', 'sss', 'Esteli', '2017-02-28 20:42:44', null);

-- ----------------------------
-- Table structure for facturas
-- ----------------------------
DROP TABLE IF EXISTS `facturas`;
CREATE TABLE `facturas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cliente` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '0',
  `total` decimal(10,2) DEFAULT '0.00',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of facturas
-- ----------------------------
INSERT INTO `facturas` VALUES ('1', 'Luis', '1', '0.00');
INSERT INTO `facturas` VALUES ('2', 'Mario', '1', '0.00');
INSERT INTO `facturas` VALUES ('3', 'Norlan', '1', '0.00');
INSERT INTO `facturas` VALUES ('4', 'Emilio', '1', '0.00');
INSERT INTO `facturas` VALUES ('5', 'msgfuiewh', '1', '0.00');
INSERT INTO `facturas` VALUES ('6', 'Edgardo', '1', '0.00');
INSERT INTO `facturas` VALUES ('7', 'Wilton', '1', '0.00');
INSERT INTO `facturas` VALUES ('8', 'Hellen', '1', '0.00');
INSERT INTO `facturas` VALUES ('9', 'Said', '1', '0.00');
INSERT INTO `facturas` VALUES ('10', 'Zohenya', '1', '0.00');
INSERT INTO `facturas` VALUES ('11', 'Luis', '1', '0.00');
INSERT INTO `facturas` VALUES ('12', 'ffffff', '1', '0.00');

-- ----------------------------
-- Table structure for factura_productos
-- ----------------------------
DROP TABLE IF EXISTS `factura_productos`;
CREATE TABLE `factura_productos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `factura_id` int(11) NOT NULL,
  `producto_id` int(11) NOT NULL,
  `cantidad` decimal(10,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`id`),
  KEY `fk_factura_idx` (`factura_id`),
  KEY `fk_factura_producto_idx` (`producto_id`),
  CONSTRAINT `fk_factura` FOREIGN KEY (`factura_id`) REFERENCES `facturas` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_factura_producto` FOREIGN KEY (`producto_id`) REFERENCES `producto` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of factura_productos
-- ----------------------------
INSERT INTO `factura_productos` VALUES ('1', '6', '24', '4.00');
INSERT INTO `factura_productos` VALUES ('2', '7', '25', '1000.00');
INSERT INTO `factura_productos` VALUES ('3', '8', '25', '100.00');
INSERT INTO `factura_productos` VALUES ('4', '8', '29', '105.00');
INSERT INTO `factura_productos` VALUES ('5', '9', '25', '1.00');
INSERT INTO `factura_productos` VALUES ('6', '10', '29', '1.00');
INSERT INTO `factura_productos` VALUES ('7', '11', '24', '14553.00');
INSERT INTO `factura_productos` VALUES ('8', '12', '29', '1.00');

-- ----------------------------
-- Table structure for inventario
-- ----------------------------
DROP TABLE IF EXISTS `inventario`;
CREATE TABLE `inventario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `producto_id` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `frecha_agregado` datetime DEFAULT CURRENT_TIMESTAMP,
  `total` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_producto_inv_idx` (`producto_id`),
  CONSTRAINT `fk_producto_inv` FOREIGN KEY (`producto_id`) REFERENCES `producto` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of inventario
-- ----------------------------
INSERT INTO `inventario` VALUES ('10', '23', '34240', '2017-03-18 13:21:55');
INSERT INTO `inventario` VALUES ('11', '24', '-15761', '2017-03-18 13:22:43');
INSERT INTO `inventario` VALUES ('12', '25', '98984235', '2017-03-29 17:51:31');
INSERT INTO `inventario` VALUES ('13', '28', '98985244', '2017-03-31 11:35:09');
INSERT INTO `inventario` VALUES ('14', '29', '5985239', '2017-03-31 12:13:07');

-- ----------------------------
-- Table structure for producto
-- ----------------------------
DROP TABLE IF EXISTS `producto`;
CREATE TABLE `producto` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_producto` varchar(255) DEFAULT NULL,
  `proveedor_id` int(11) DEFAULT NULL,
  `precio_compra` decimal(10,2) DEFAULT NULL,
  `precio_venta` decimal(10,2) DEFAULT NULL,
  `categoria_id` int(11) DEFAULT NULL,
  `fecha_creacion` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `fk_categoria_art_idx` (`categoria_id`),
  KEY `fk_proveedor_prod_idx` (`proveedor_id`),
  CONSTRAINT `fk_categoria_art` FOREIGN KEY (`categoria_id`) REFERENCES `categorias` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_proveedor_prod` FOREIGN KEY (`proveedor_id`) REFERENCES `proveedores` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of producto
-- ----------------------------
INSERT INTO `producto` VALUES ('23', 'mmmmmm', '8', '100.00', '200.00', '4', '2017-03-18 13:21:43');
INSERT INTO `producto` VALUES ('24', 'rvrgrgrgr', '9', '50.00', '70.00', '5', '2017-03-18 13:22:32');
INSERT INTO `producto` VALUES ('25', 'gbbmfkmf', '8', '500.00', '1000.00', '4', '2017-03-21 17:51:25');
INSERT INTO `producto` VALUES ('28', 'Centrolac', '8', '250.00', '300.00', '4', '2017-03-31 11:35:09');
INSERT INTO `producto` VALUES ('29', 'Centrolac', '8', '250.00', '300.00', '4', '2017-03-31 12:13:07');

-- ----------------------------
-- Table structure for proveedores
-- ----------------------------
DROP TABLE IF EXISTS `proveedores`;
CREATE TABLE `proveedores` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) DEFAULT NULL,
  `apellido` varchar(255) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `id_distribuidora` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_distribuidora` (`id_distribuidora`),
  CONSTRAINT `fk_distribuidora` FOREIGN KEY (`id_distribuidora`) REFERENCES `distribuidora` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of proveedores
-- ----------------------------
INSERT INTO `proveedores` VALUES ('8', 'luis', 'centeno', '22222155', null);
INSERT INTO `proveedores` VALUES ('9', 'Walter', 'Centeno', '7777777', null);

-- ----------------------------
-- Table structure for usuario
-- ----------------------------
DROP TABLE IF EXISTS `usuario`;
CREATE TABLE `usuario` (
  `id_usuario` int(255) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) DEFAULT NULL,
  `contra` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of usuario
-- ----------------------------
INSERT INTO `usuario` VALUES ('1', 'Edgardo', '123');
INSERT INTO `usuario` VALUES ('2', 'Norlan', '1234');

-- ----------------------------
-- Table structure for ventas
-- ----------------------------
DROP TABLE IF EXISTS `ventas`;
CREATE TABLE `ventas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `articulo_id` int(11) DEFAULT NULL,
  `cantidad` varchar(255) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `usuario_id` int(11) DEFAULT NULL,
  `fecha_venta` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `fk_venta_productos_inv` (`articulo_id`),
  CONSTRAINT `fk_producto_venta` FOREIGN KEY (`articulo_id`) REFERENCES `producto` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of ventas
-- ----------------------------
INSERT INTO `ventas` VALUES ('1', '24', '4.00', '280.00', null, '2017-03-29 20:16:01');
INSERT INTO `ventas` VALUES ('2', '25', '1000.00', '1000000.00', null, '2017-03-29 20:22:23');
INSERT INTO `ventas` VALUES ('3', '25', '100.00', '100000.00', null, '2017-03-31 14:44:59');
INSERT INTO `ventas` VALUES ('4', '29', '105.00', '31500.00', null, '2017-03-31 14:44:59');
INSERT INTO `ventas` VALUES ('5', '25', '1.00', '1000.00', null, '2017-03-31 14:52:38');
INSERT INTO `ventas` VALUES ('6', '29', '1.00', '300.00', null, '2017-03-31 14:53:14');
INSERT INTO `ventas` VALUES ('7', '24', '14553.00', '1018710.00', null, '2017-03-31 14:57:29');
INSERT INTO `ventas` VALUES ('8', '29', '1.00', '300.00', null, '2017-03-31 14:57:56');

-- ----------------------------
-- View structure for v_vencidos
-- ----------------------------
DROP VIEW IF EXISTS `v_vencidos`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER  VIEW `v_vencidos` AS SELECT
compra_productos.cantidad,
compra_productos.inventario_id,
compra_productos.fecha_vencimiento,
inventario.producto_id,
producto.nombre_producto
FROM
compra_productos
INNER JOIN inventario ON compra_productos.inventario_id = inventario.id
INNER JOIN producto ON inventario.producto_id = producto.id ;

-- ----------------------------
-- View structure for v_vencidos_ejemploprofealan
-- ----------------------------
DROP VIEW IF EXISTS `v_vencidos_ejemploprofealan`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost`  VIEW `v_vencidos_ejemploprofealan` AS SELECT
producto.nombre_producto,
producto.proveedor_id,
producto.precio_compra,
lotes.fecha_vencimiento,
lotes.cantidad
FROM
producto
INNER JOIN lotes ON producto.id_lote = lotes.id_lote
WHERE lotes.fecha_vencimiento>'2017-03-27' ;

-- ----------------------------
-- Procedure structure for buscar_producto
-- ----------------------------
DROP PROCEDURE IF EXISTS `buscar_producto`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `buscar_producto`(IN `articulo` varchar(95))
BEGIN
	SELECT
producto.nombre,
producto.precio_venta,
inventario.producto_id,
inventario.cantidad
FROM
inventario
INNER JOIN producto ON inventario.producto_id = producto.id
WHERE producto.nombre = articulo;

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for buscar_proveedor
-- ----------------------------
DROP PROCEDURE IF EXISTS `buscar_proveedor`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `buscar_proveedor`(IN `proveedor_datos` varchar(95))
BEGIN
	SELECT
proveedores.id,
proveedores.nombre,
proveedores.telefono,
proveedores.id_distribuidora,
proveedores.apellido
FROM
proveedores


where 
proveedores.nombre = proveedor_datos;

END
;;
DELIMITER ;
DROP TRIGGER IF EXISTS `compra_productos_AFTER_INSERT`;
DELIMITER ;;
CREATE TRIGGER `compra_productos_AFTER_INSERT` AFTER INSERT ON `compra_productos` FOR EACH ROW BEGIN
UPDATE `distribuidora_el_buen_precio`.`inventario` SET `cantidad` = `cantidad` + new.cantidad WHERE `id`=new.inventario_id ;

END
;;
DELIMITER ;
DROP TRIGGER IF EXISTS `producto_AFTER_INSERT`;
DELIMITER ;;
CREATE TRIGGER `producto_AFTER_INSERT` AFTER INSERT ON `producto` FOR EACH ROW BEGIN
INSERT INTO `distribuidora_el_buen_precio`.`inventario` (`producto_id`, `cantidad`) VALUES (new.id, '0');
END
;;
DELIMITER ;
DROP TRIGGER IF EXISTS `venta_productos`;
DELIMITER ;;
CREATE TRIGGER `venta_productos` AFTER INSERT ON `ventas` FOR EACH ROW BEGIN
UPDATE `distribuidora_el_buen_precio`.`inventario` SET `cantidad`= `cantidad` - new.cantidad;

END
;;
DELIMITER ;
