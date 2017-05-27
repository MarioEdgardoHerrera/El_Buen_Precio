/*
Navicat MySQL Data Transfer

Source Server         : Mysql
Source Server Version : 50617
Source Host           : 127.0.0.1:3306
Source Database       : distribuidora_el_buen_precio

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2017-05-27 07:58:46
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of categorias
-- ----------------------------
INSERT INTO `categorias` VALUES ('2', 'Jabones', null);

-- ----------------------------
-- Table structure for compra_productos
-- ----------------------------
DROP TABLE IF EXISTS `compra_productos`;
CREATE TABLE `compra_productos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `emplado_id` int(11) DEFAULT NULL,
  `cantidad` decimal(10,2) DEFAULT NULL,
  `inventario_id` int(11) DEFAULT NULL,
  `fecha_compra` datetime DEFAULT CURRENT_TIMESTAMP,
  `fecha_vencimiento` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `fk_entradas_inventario_inv_idx` (`inventario_id`),
  KEY `fk_empleado_compra_idx` (`emplado_id`),
  KEY `cantidad` (`cantidad`),
  CONSTRAINT `fk_compra_productos_inv` FOREIGN KEY (`inventario_id`) REFERENCES `inventario` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_empleado_compra` FOREIGN KEY (`emplado_id`) REFERENCES `emplados` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of compra_productos
-- ----------------------------
INSERT INTO `compra_productos` VALUES ('6', '1', '100.00', '2', '2017-05-26 00:00:00', '2017-05-26 00:00:00');

-- ----------------------------
-- Table structure for distribuidora
-- ----------------------------
DROP TABLE IF EXISTS `distribuidora`;
CREATE TABLE `distribuidora` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of distribuidora
-- ----------------------------

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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of emplados
-- ----------------------------
INSERT INTO `emplados` VALUES ('1', 'Norlan', 'Sanchez', '01234567', 'Soltero', 'Esteli', '2017-05-26 18:00:11', null);

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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of facturas
-- ----------------------------
INSERT INTO `facturas` VALUES ('2', 'Erick', '1', '0.00');

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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of factura_productos
-- ----------------------------
INSERT INTO `factura_productos` VALUES ('4', '2', '3', '1.00');

-- ----------------------------
-- Table structure for inventario
-- ----------------------------
DROP TABLE IF EXISTS `inventario`;
CREATE TABLE `inventario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `producto_id` int(11) DEFAULT NULL,
  `cantidad` decimal(10,2) DEFAULT NULL,
  `frecha_agregado` datetime DEFAULT CURRENT_TIMESTAMP,
  `total` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_producto_inv_idx` (`producto_id`),
  CONSTRAINT `fk_producto_inv` FOREIGN KEY (`producto_id`) REFERENCES `producto` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of inventario
-- ----------------------------
INSERT INTO `inventario` VALUES ('2', '3', '99.00', '2017-05-25 17:07:12', null);

-- ----------------------------
-- Table structure for producto
-- ----------------------------
DROP TABLE IF EXISTS `producto`;
CREATE TABLE `producto` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_producto` varchar(255) NOT NULL,
  `proveedor_id` int(11) DEFAULT NULL,
  `precio_compra` decimal(10,2) DEFAULT NULL,
  `precio_venta` decimal(10,2) DEFAULT NULL,
  `categoria_id` int(11) DEFAULT NULL,
  `fecha_creacion` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`,`nombre_producto`),
  KEY `fk_categoria_art_idx` (`categoria_id`),
  KEY `fk_proveedor_prod_idx` (`proveedor_id`),
  CONSTRAINT `fk_categoria_art` FOREIGN KEY (`categoria_id`) REFERENCES `categorias` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_proveedor_prod` FOREIGN KEY (`proveedor_id`) REFERENCES `proveedores` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of producto
-- ----------------------------
INSERT INTO `producto` VALUES ('3', 'Millon', '2', '15.00', '18.00', '2', '2017-05-25 17:07:12');

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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of proveedores
-- ----------------------------
INSERT INTO `proveedores` VALUES ('2', 'Juan', 'Games', '01234567', null);

-- ----------------------------
-- Table structure for usuario
-- ----------------------------
DROP TABLE IF EXISTS `usuario`;
CREATE TABLE `usuario` (
  `id_usuario` int(255) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(255) DEFAULT NULL,
  `contra` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of usuario
-- ----------------------------
INSERT INTO `usuario` VALUES ('5', 'Edgardo', '123');

-- ----------------------------
-- Table structure for ventas
-- ----------------------------
DROP TABLE IF EXISTS `ventas`;
CREATE TABLE `ventas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `articulo_id` int(11) DEFAULT NULL,
  `cantidad` decimal(10,2) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `usuario_id` int(11) DEFAULT NULL,
  `fecha_venta` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  KEY `fk_venta_productos_inv` (`articulo_id`),
  CONSTRAINT `fk_producto_venta` FOREIGN KEY (`articulo_id`) REFERENCES `producto` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of ventas
-- ----------------------------
INSERT INTO `ventas` VALUES ('7', '3', '1.00', '18.50', null, '2017-05-25 17:52:08');

-- ----------------------------
-- View structure for v_vencidos
-- ----------------------------
DROP VIEW IF EXISTS `v_vencidos`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER  VIEW `v_vencidos` AS select `distribuidora_el_buen_precio`.`compra_productos`.`cantidad` AS `cantidad`,`distribuidora_el_buen_precio`.`compra_productos`.`inventario_id` AS `inventario_id`,`distribuidora_el_buen_precio`.`compra_productos`.`fecha_vencimiento` AS `fecha_vencimiento`,`distribuidora_el_buen_precio`.`inventario`.`producto_id` AS `producto_id`,`distribuidora_el_buen_precio`.`producto`.`nombre_producto` AS `nombre_producto` from ((`distribuidora_el_buen_precio`.`compra_productos` join `distribuidora_el_buen_precio`.`inventario` on((`distribuidora_el_buen_precio`.`compra_productos`.`inventario_id` = `distribuidora_el_buen_precio`.`inventario`.`id`))) join `distribuidora_el_buen_precio`.`producto` on((`distribuidora_el_buen_precio`.`inventario`.`producto_id` = `distribuidora_el_buen_precio`.`producto`.`id`))) ;

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

-- ----------------------------
-- Procedure structure for modificar_producto
-- ----------------------------
DROP PROCEDURE IF EXISTS `modificar_producto`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `modificar_producto`(IN `p1` VARCHAR(255), IN `p2` INT, IN `p3` DECIMAL, IN `p4` DECIMAL, IN `p5` INT, IN `p6` INT)
BEGIN
	update producto set nombre_producto=p1, proveedor_id=p2,precio_compra=p3,precio_venta=p4,categoria_id=p5 
    where id=p6;
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
