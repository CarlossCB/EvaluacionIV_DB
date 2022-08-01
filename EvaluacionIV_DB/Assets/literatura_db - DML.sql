-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 01-08-2022 a las 05:14:17
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 8.1.6

SET FOREIGN_KEY_CHECKS=0;
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `literatura_db`
--

--
-- Volcado de datos para la tabla `autor`
--

INSERT INTO `autor` (`Id`, `Nombre`, `Edad`, `FechaNacimiento`, `Activo`) VALUES
(1, 'Stephen King\r\n', 75, '1947-09-21 00:00:00', 1),
(2, 'Mia Couto\r\n', 67, '1955-07-05 00:00:00', 1),
(3, 'Herta Müller\r\n', 68, '1953-08-17 00:00:00', 1);

--
-- Volcado de datos para la tabla `libro`
--

INSERT INTO `libro` (`Id`, `AutorId`, `Titulo`, `NroPaginas`) VALUES
(1, 1, 'It', 1244),
(2, 1, 'El resplandor', 643),
(3, 1, 'Misery', 431),
(4, 1, 'Cementerio de animales', 436),
(5, 1, 'El pasillo de la muerte', 413),
(6, 1, 'Ojos de fuego', 416),
(7, 1, 'El visitante', 685),
(8, 1, 'Cujo', 463),
(9, 1, 'Doctor Sueño', 696),
(10, 1, 'El misterio de Salem\'s Lot', 601),
(11, 2, 'Tierra sonámbula', 233),
(12, 2, 'La confesión de la leona', 164),
(13, 2, 'Jesusalén', 204),
(14, 2, 'El mapeador de ausencias', 275),
(15, 2, 'El balcón del Frangipani', 143),
(16, 2, 'Trilogía de Mozambique', 753),
(17, 2, 'La terraza del frangipani', 164),
(18, 2, 'Africa', 572),
(19, 2, 'The Sword and the Spear: A Novel', 683),
(20, 2, 'Vinte e zinco', 794),
(21, 3, 'Todo lo que tengo lo llevo conmigo', 187),
(22, 3, 'La bestia del corazón', 132),
(23, 3, 'El rey se inclina y mata', 169),
(24, 3, 'Siempre la misma nieve y siempre el mismo tío', 254),
(25, 3, 'Hambre y seda', 154),
(26, 3, 'Mi patria era una semilla de manzana', 243),
(27, 3, 'En la trampa: Tres ensayos', 121),
(28, 3, 'Los pálidos señores con las tazas de moca', 232),
(29, 3, 'Traveling on One Leg', 343),
(30, 3, 'El hombre es un gran faisán en el mundo', 454);
SET FOREIGN_KEY_CHECKS=1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
