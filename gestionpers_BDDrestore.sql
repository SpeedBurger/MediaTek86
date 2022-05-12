-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 06 mai 2022 à 13:17
-- Version du serveur : 10.6.5-MariaDB
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : gestionpers
--
CREATE DATABASE IF NOT EXISTS gestionpers DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
CREATE USER 'gestionpers'@'%' IDENTIFIED BY 'motdepasseuser';
GRANT USAGE ON *.* TO 'gestionpers'@'%';
GRANT ALL PRIVILEGES ON `gestionpers`.* TO 'gestionpers'@'%';
USE gestionpers;

-- --------------------------------------------------------

--
-- Structure de la table absence
--

DROP TABLE IF EXISTS absence;
CREATE TABLE IF NOT EXISTS absence (
  idpersonnel int(2) NOT NULL,
  datedebut datetime NOT NULL,
  idmotif int(2) NOT NULL,
  datefin datetime DEFAULT NULL,
  PRIMARY KEY (idpersonnel,datedebut),
  KEY i_fk_absence_motif1 (idmotif),
  KEY i_fk_absence_personnel1 (idpersonnel)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table absence
--

INSERT INTO absence (idpersonnel, datedebut, idmotif, datefin) VALUES
(21, '2021-11-23 09:36:13', 1, '2021-09-04 07:03:04'),
(21, '2022-04-15 16:16:59', 2, '2021-12-24 19:37:04'),
(22, '2021-07-27 04:40:37', 3, '2022-03-07 06:52:28'),
(22, '2021-09-05 10:22:06', 3, '2021-07-29 21:29:51'),
(22, '2021-09-28 13:41:40', 1, '2021-12-08 12:01:23'),
(22, '2021-12-30 11:50:30', 2, '2022-03-13 08:30:40'),
(22, '2022-03-20 10:54:18', 3, '2021-09-06 14:01:03'),
(23, '2021-07-13 13:05:38', 2, '2021-05-28 22:55:05'),
(23, '2022-04-30 13:47:13', 2, '2021-09-23 05:29:40'),
(24, '2021-09-18 11:05:53', 3, '2021-11-26 04:59:07'),
(24, '2021-11-23 05:35:32', 1, '2021-09-01 14:41:32'),
(24, '2021-12-30 11:31:59', 2, '2021-07-28 15:03:05'),
(24, '2022-01-03 11:15:59', 2, '2021-12-26 19:56:35'),
(24, '2022-03-10 02:11:47', 3, '2021-11-20 17:51:08'),
(24, '2022-03-24 21:37:03', 3, '2022-01-21 15:09:05'),
(24, '2022-04-20 15:51:51', 1, '2021-10-27 02:28:27'),
(25, '2021-09-04 13:26:08', 2, '2021-06-18 11:51:47'),
(25, '2021-09-13 07:48:08', 2, '2022-04-30 07:43:30'),
(25, '2021-11-24 01:43:55', 1, '2021-05-28 20:16:21'),
(25, '2021-12-26 21:09:48', 1, '2022-04-18 06:27:42'),
(25, '2022-02-07 16:48:31', 1, '2022-04-06 22:45:40'),
(25, '2022-03-19 19:19:11', 2, '2021-05-10 19:14:08'),
(26, '2021-06-20 18:31:10', 1, '2022-04-21 08:18:24'),
(26, '2022-01-23 12:11:23', 2, '2021-10-31 20:09:24'),
(26, '2022-04-01 23:09:34', 2, '2022-02-10 00:20:30'),
(26, '2022-04-12 05:04:26', 3, '2021-12-27 15:17:22'),
(26, '2022-04-29 13:03:48', 2, '2022-03-17 14:30:50'),
(27, '2021-05-24 17:45:45', 2, '2021-12-14 01:42:47'),
(27, '2021-06-01 03:24:05', 2, '2021-05-22 22:10:18'),
(27, '2021-07-13 07:45:26', 1, '2022-02-13 17:24:23'),
(27, '2021-08-27 08:01:29', 1, '2021-06-12 06:55:37'),
(27, '2021-10-11 01:40:39', 2, '2022-04-30 18:48:26'),
(27, '2022-01-13 23:51:10', 2, '2021-10-22 21:10:51'),
(27, '2022-02-16 02:26:51', 3, '2021-07-29 03:27:57'),
(27, '2022-04-15 04:18:27', 2, '2021-07-19 09:11:29'),
(27, '2022-04-22 02:44:23', 2, '2022-04-04 09:58:15'),
(28, '2021-06-04 12:39:51', 2, '2022-04-03 05:28:44'),
(28, '2021-06-07 16:03:45', 3, '2021-05-08 22:38:37'),
(28, '2021-07-09 06:19:17', 2, '2022-04-14 16:51:02'),
(28, '2021-08-20 10:58:00', 1, '2022-04-19 08:58:36'),
(28, '2021-12-01 17:00:10', 2, '2021-09-27 23:39:37'),
(28, '2022-01-29 19:43:28', 2, '2022-04-07 07:36:00'),
(28, '2022-03-04 13:46:36', 1, '2021-08-28 09:33:33'),
(28, '2022-03-09 20:56:53', 3, '2021-07-24 12:48:20'),
(29, '2021-05-20 10:27:32', 3, '2021-07-08 23:59:57'),
(29, '2021-07-19 15:16:29', 1, '2021-08-23 12:41:29'),
(29, '2022-03-14 19:52:19', 2, '2022-04-20 01:27:36'),
(29, '2022-04-16 05:56:48', 1, '2022-04-13 02:18:00'),
(29, '2022-05-02 22:38:47', 3, '2021-05-18 06:45:17'),
(30, '2021-08-12 13:16:34', 2, '2021-06-11 23:51:13');

-- --------------------------------------------------------

--
-- Structure de la table motif
--

DROP TABLE IF EXISTS motif;
CREATE TABLE IF NOT EXISTS motif (
  idmotif int(2) NOT NULL AUTO_INCREMENT,
  libelle varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (idmotif)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table motif
--

INSERT INTO motif (idmotif, libelle) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table personnel
--

DROP TABLE IF EXISTS personnel;
CREATE TABLE IF NOT EXISTS personnel (
  idpersonnel int(2) NOT NULL AUTO_INCREMENT,
  idservice int(2) NOT NULL,
  nom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  prenom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  tel varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  mail varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (idpersonnel),
  KEY i_fk_personnel_service1 (idservice)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table personnel
--

INSERT INTO personnel (idpersonnel, idservice, nom, prenom, tel, mail) VALUES
(21, 1, 'Trevor', 'Marshall', '07 94 67 53 98', 'ut@icloud.edu'),
(22, 2, 'Signe', 'Banks', '05 86 75 23 29', 'suspendisse.ac@protonmail.edu'),
(23, 3, 'Montana', 'Watkins', '06 31 62 10 10', 'arcu.vestibulum.ante@yahoo.net'),
(24, 1, 'Felicia', 'Vega', '04 92 54 26 73', 'vehicula.risus@hotmail.ca'),
(25, 2, 'Tanya', 'Pierce', '04 17 88 17 76', 'ut@google.ca'),
(26, 3, 'Aphrodite', 'Clarke', '09 44 13 48 18', 'ac.mattis@outlook.edu'),
(27, 1, 'Leila', 'Edwards', '04 24 37 76 87', 'nullam.lobortis@outlook.edu'),
(28, 2, 'Myra', 'Davis', '05 35 67 37 63', 'vestibulum.mauris@icloud.ca'),
(29, 3, 'Nell', 'Lewis', '06 52 13 71 11', 'a.purus.duis@protonmail.net'),
(30, 1, 'Palmer', 'Green', '01 88 15 27 85', 'magna@hotmail.com');

-- --------------------------------------------------------

--
-- Structure de la table responsable
--

DROP TABLE IF EXISTS responsable;
CREATE TABLE IF NOT EXISTS responsable (
  login varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  pwd varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table responsable
--

INSERT INTO responsable (login, pwd) VALUES
('gestionpers', '254ad9a19af3b990a6643a443eb353d4d4584e66858bbdd2fb0cbd3b395c73d8');

-- --------------------------------------------------------

--
-- Structure de la table service
--

DROP TABLE IF EXISTS service;
CREATE TABLE IF NOT EXISTS service (
  idservice int(2) NOT NULL AUTO_INCREMENT,
  nom varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (idservice)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table service
--

INSERT INTO service (idservice, nom) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table absence
--
ALTER TABLE absence
  ADD CONSTRAINT FK_absence_motif FOREIGN KEY (idmotif) REFERENCES motif (idmotif),
  ADD CONSTRAINT FK_absence_personnel FOREIGN KEY (idpersonnel) REFERENCES personnel (idpersonnel);

--
-- Contraintes pour la table personnel
--
ALTER TABLE personnel
  ADD CONSTRAINT FK_personnel_service FOREIGN KEY (idservice) REFERENCES service (idservice);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
