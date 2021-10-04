-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 30 Ara 2020, 18:35:55
-- Sunucu sürümü: 10.4.17-MariaDB
-- PHP Sürümü: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `131730026odev8`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `personel`
--

CREATE TABLE `personel` (
  `id` int(11) NOT NULL,
  `name` varchar(80) COLLATE utf8_turkish_ci NOT NULL,
  `surname` varchar(80) COLLATE utf8_turkish_ci NOT NULL,
  `adres` text COLLATE utf8_turkish_ci NOT NULL,
  `phone_number` varchar(12) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `personel`
--

INSERT INTO `personel` (`id`, `name`, `surname`, `adres`, `phone_number`) VALUES
(2, 'sad', 'asd', 'sad', 'asd'),
(3, '231', '123', '12323', '123'),
(4, '23', '21', '123', '123'),
(5, '12', '\"12', '12312', '123'),
(6, '123', '32', '123', '123'),
(7, 'sdfa', 'asdf', 'sadfas', 'sdafas'),
(9, 'asd', 'asd', 'sd', 'asd'),
(10, '123', '123', '12323', '123'),
(11, 'bilal', 'alptekin', 'istanbul beylikdüzü kavaklı mahallesi üü', '789879878');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `personel`
--
ALTER TABLE `personel`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `personel`
--
ALTER TABLE `personel`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
