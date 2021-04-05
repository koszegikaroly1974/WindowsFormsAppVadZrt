-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Dec 09. 19:11
-- Kiszolgáló verziója: 10.1.40-MariaDB
-- PHP verzió: 7.3.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `szf43koszegikaroly`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ertekesites`
--

CREATE TABLE `ertekesites` (
  `szallitolevel_sorszam` int(255) NOT NULL,
  `vevo_azonosito` int(255) NOT NULL,
  `termek_azonosito` int(255) NOT NULL,
  `ertekesites_datuma` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `ertekesites`
--

INSERT INTO `ertekesites` (`szallitolevel_sorszam`, `vevo_azonosito`, `termek_azonosito`, `ertekesites_datuma`) VALUES
(1, 1, 1, '2019-12-08');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jelszo`
--

CREATE TABLE `jelszo` (
  `jelszo_azon` int(11) NOT NULL,
  `agazat` varchar(15) COLLATE utf8_hungarian_ci NOT NULL,
  `felhasznalonev` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `jelszo` varchar(10) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `jelszo`
--

INSERT INTO `jelszo` (`jelszo_azon`, `agazat`, `felhasznalonev`, `jelszo`) VALUES
(1, 'termeles', 'termeles', 'termeles'),
(2, 'raktar', 'raktar', 'raktar'),
(3, 'admin', 'admin', 'admin');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `raktar`
--

CREATE TABLE `raktar` (
  `termek_egyedi_azonosito` int(255) NOT NULL,
  `cikkszam` varchar(15) COLLATE utf8_hungarian_ci NOT NULL,
  `termek_neve` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `mennyiseg_1` int(11) NOT NULL,
  `mennyisegi_egyseg_1` varchar(6) COLLATE utf8_hungarian_ci NOT NULL,
  `mennyiseg_2` int(11) NOT NULL,
  `mennyisegi_egyseg_2` varchar(6) COLLATE utf8_hungarian_ci NOT NULL,
  `sarzs` int(11) NOT NULL,
  `gyartasi_datum` date NOT NULL,
  `lejarati_datum` date NOT NULL,
  `termek_allapot` varchar(15) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `raktar`
--

INSERT INTO `raktar` (`termek_egyedi_azonosito`, `cikkszam`, `termek_neve`, `mennyiseg_1`, `mennyisegi_egyseg_1`, `mennyiseg_2`, `mennyisegi_egyseg_2`, `sarzs`, `gyartasi_datum`, `lejarati_datum`, `termek_allapot`) VALUES
(1, 'SVK010506', 'Őzcomb csont nélkül', 12, 'kg', 1, 'karton', 1, '2019-01-02', '2022-01-01', 'keszleten'),
(2, 'SVK010506', 'Őzcomb csont nélkül', 12, 'kg', 1, 'karton', 1, '2019-01-02', '2022-01-02', 'keszleten'),
(3, 'SVK010506', 'Őzcomb csont nélkül', 12, 'kg', 1, 'karton', 1, '2019-01-02', '2022-01-01', 'kiadva'),
(4, 'SVK010506', 'Őzcomb csont nélkül', 12, 'kg', 1, 'karton', 1, '2019-01-02', '2022-01-01', 'kiadva'),
(5, 'SVK010512', 'Őzragu B csont nélkül', 12, 'kg', 1, 'karton', 1, '2019-01-02', '2022-01-01', 'keszleten'),
(6, 'SVK010512', 'Őzragu B csont nélkül', 12, 'kg', 1, 'karton', 1, '2019-01-02', '2022-01-01', 'keszleten'),
(7, 'SVK010512', 'Őzragu B csont nélkül', 12, 'kg', 1, 'karton', 1, '2019-01-02', '2022-01-01', 'keszleten'),
(8, 'SVK010512', 'Őzragu B csont nélkül', 12, 'kg', 1, 'karton', 1, '2019-01-02', '2022-01-01', 'keszleten'),
(9, 'SVK020506', 'szarvascomb csont nélkül', 12, 'kg', 1, 'karton', 2, '2019-01-02', '2022-01-01', 'keszleten'),
(10, 'SVK020506', 'szarvascomb csont nélkül', 12, 'kg', 1, 'karton', 2, '2019-01-02', '2022-01-01', 'keszleten'),
(11, 'SVK020506', 'szarvascomb csont nélkül', 12, 'kg', 1, 'karton', 2, '2019-01-02', '2022-01-01', 'keszleten'),
(12, 'SVK020506', 'szarvascomb csont nélkül', 12, 'kg', 1, 'karton', 2, '2019-01-02', '2022-01-01', 'keszleten'),
(13, 'SVK021304', 'szarvasragu B csont nélkül', 12, 'kg', 1, 'karton', 2, '2019-01-02', '2022-01-01', 'keszleten'),
(14, 'SVK021304', 'szarvasragu B csont nélkül', 12, 'kg', 1, 'karton', 2, '2019-01-02', '2022-01-01', 'keszleten'),
(15, 'SVK021304', 'szarvasragu B csont nélkül', 12, 'kg', 1, 'karton', 2, '2019-01-02', '2022-01-01', 'keszleten'),
(16, 'SVK021304', 'szarvasragu B csont nélkül', 12, 'kg', 1, 'karton', 2, '2019-01-02', '2022-01-01', 'keszleten'),
(17, 'SVK060508', 'vaddisznócomb csont nélkül', 12, 'kg', 1, 'karton', 3, '2019-01-02', '2022-01-01', 'keszleten'),
(18, 'SVK060508', 'vaddisznócomb csont nélkül', 12, 'kg', 1, 'karton', 3, '2019-01-02', '2022-01-01', 'keszleten'),
(19, 'SVK060508', 'vaddisznócomb csont nélkül', 12, 'kg', 1, 'karton', 3, '2019-01-02', '2022-01-01', 'keszleten'),
(20, 'SVK060508', 'vaddisznócomb csont nélkül', 12, 'kg', 1, 'karton', 3, '2019-01-02', '2022-01-01', 'keszleten'),
(21, 'SVK061304', 'vaddisznóragu B csont nélkül', 12, 'kg', 1, 'karton', 3, '2019-01-02', '2022-01-01', 'keszleten'),
(22, 'SVK061304', 'vaddisznóragu B csont nélkül', 12, 'kg', 1, 'karton', 3, '2019-01-02', '2022-01-01', 'keszleten'),
(23, 'SVK061304', 'vaddisznóragu B csont nélkül', 12, 'kg', 1, 'karton', 3, '2019-01-02', '2022-01-01', 'keszleten'),
(24, 'SVK061304', 'vaddisznóragu B csont nélkül', 12, 'kg', 1, 'karton', 3, '2019-01-02', '2022-01-01', 'keszleten'),
(25, 'SVK310103', 'fácán 700gr', 12, 'db', 1, 'karton', 4, '2019-02-02', '2021-02-01', 'keszleten'),
(26, 'SVK310103', 'fácán 700gr', 12, 'db', 1, 'karton', 4, '2019-02-02', '2021-02-01', 'keszleten'),
(27, 'SVK310104', 'fácán 800gr', 9, 'db', 1, 'karton', 4, '2019-02-02', '2021-02-01', 'keszleten'),
(28, 'SVK310104', 'fácán 800gr', 9, 'db', 1, 'karton', 4, '2019-02-02', '2021-02-01', 'keszleten'),
(29, 'SVK310105', 'fácán 900gr', 9, 'db', 1, 'karton', 4, '2019-02-02', '2021-02-01', 'keszleten'),
(30, 'SVK310105', 'fácán 900gr', 9, 'db', 1, 'karton', 4, '2019-02-02', '2021-02-01', 'keszleten'),
(31, 'SVK310105', 'fácán 900gr', 9, 'db', 1, 'karton', 4, '2019-02-02', '2021-02-01', 'keszleten'),
(32, 'SVK310106', 'fácán 1000gr', 8, 'db', 1, 'karton', 4, '2019-02-02', '2021-02-01', 'keszleten'),
(33, 'SVK010512', 'Oz ragu B', 12, 'kg', 1, 'karton', 1, '2019-12-03', '2022-12-03', 'keszleten'),
(34, 'SVK060508', 'Vaddisznócomb csont nélkül', 12, 'kg', 1, 'karton', 3, '2019-12-03', '2022-12-03', 'keszleten'),
(35, 'SVK021304', 'Szarvas ragu B', 12, 'kg', 1, 'karton', 4, '2019-12-03', '2022-12-03', 'keszleten'),
(36, 'SVK310106', 'Fácán 1000gr', 8, 'db', 1, 'karton', 10, '2019-12-07', '2022-12-07', 'keszleten');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `szallitolevel`
--

CREATE TABLE `szallitolevel` (
  `szallitolevel_sorszam` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `szallitolevel`
--

INSERT INTO `szallitolevel` (`szallitolevel_sorszam`) VALUES
(1),
(38),
(39);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `termek`
--

CREATE TABLE `termek` (
  `cikkszam` varchar(15) COLLATE utf8_hungarian_ci NOT NULL,
  `termek_neve` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `mennyisegi_egyseg_1` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `mennyisegi_egyseg_2` varchar(10) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `termek`
--

INSERT INTO `termek` (`cikkszam`, `termek_neve`, `mennyisegi_egyseg_1`, `mennyisegi_egyseg_2`) VALUES
('SVK010506', 'Őzcomb csont nélkül', 'kg', 'karton'),
('SVK010512', 'Őz ragu B', 'kg', 'karton'),
('SVK020506', 'Szarvascomb csont nélkül', 'kg', 'karton'),
('SVK021304', 'Szarvas ragu B', 'kg', 'karton'),
('SVK060508', 'Vaddisznócomb csont nélkül', 'kg', 'karton'),
('SVK061304', 'Vaddisznó ragu B', 'kg', 'karton'),
('SVK310103', 'Fácán 700gr', 'db', 'karton'),
('SVK310104', 'Fácán 800gr', 'db', 'karton'),
('SVK310105', 'Fácán 900gr', 'db', 'karton'),
('SVK310106', 'Fácán 1000gr', 'db', 'karton');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vevok`
--

CREATE TABLE `vevok` (
  `vevo_azonosito` int(255) NOT NULL,
  `vevo_neve` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `vevo_cime` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `vevo_adoszam` varchar(8) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `vevok`
--

INSERT INTO `vevok` (`vevo_azonosito`, `vevo_neve`, `vevo_cime`, `vevo_adoszam`) VALUES
(1, 'Kiss Károly', '6000 Kecskemét Kis utca 2', '80000000'),
(2, 'Nagy Norbert', '4400 Nyíregyháza Nap utca 4', '81111111'),
(3, 'Tóth Tamás', '2890 Tata Tuti tér 10', '82222222'),
(4, 'Szabó Szilárd', '6700 Szeged Szeg utca 100', '83333333'),
(5, 'Kovács Kálmán', 'Keszthely', '84444445');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `ertekesites`
--
ALTER TABLE `ertekesites`
  ADD KEY `termek_azonosito` (`vevo_azonosito`),
  ADD KEY `termek_azonosito_2` (`termek_azonosito`),
  ADD KEY `szallitolevel` (`szallitolevel_sorszam`);

--
-- A tábla indexei `jelszo`
--
ALTER TABLE `jelszo`
  ADD PRIMARY KEY (`jelszo_azon`);

--
-- A tábla indexei `raktar`
--
ALTER TABLE `raktar`
  ADD PRIMARY KEY (`termek_egyedi_azonosito`),
  ADD KEY `cikkszam` (`cikkszam`);

--
-- A tábla indexei `szallitolevel`
--
ALTER TABLE `szallitolevel`
  ADD PRIMARY KEY (`szallitolevel_sorszam`);

--
-- A tábla indexei `termek`
--
ALTER TABLE `termek`
  ADD PRIMARY KEY (`cikkszam`);

--
-- A tábla indexei `vevok`
--
ALTER TABLE `vevok`
  ADD PRIMARY KEY (`vevo_azonosito`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `jelszo`
--
ALTER TABLE `jelszo`
  MODIFY `jelszo_azon` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT a táblához `raktar`
--
ALTER TABLE `raktar`
  MODIFY `termek_egyedi_azonosito` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT a táblához `szallitolevel`
--
ALTER TABLE `szallitolevel`
  MODIFY `szallitolevel_sorszam` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT a táblához `vevok`
--
ALTER TABLE `vevok`
  MODIFY `vevo_azonosito` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `ertekesites`
--
ALTER TABLE `ertekesites`
  ADD CONSTRAINT `ertekesites_ibfk_1` FOREIGN KEY (`vevo_azonosito`) REFERENCES `vevok` (`vevo_azonosito`),
  ADD CONSTRAINT `ertekesites_ibfk_2` FOREIGN KEY (`termek_azonosito`) REFERENCES `raktar` (`termek_egyedi_azonosito`),
  ADD CONSTRAINT `ertekesites_ibfk_3` FOREIGN KEY (`szallitolevel_sorszam`) REFERENCES `szallitolevel` (`szallitolevel_sorszam`);

--
-- Megkötések a táblához `raktar`
--
ALTER TABLE `raktar`
  ADD CONSTRAINT `raktar_ibfk_1` FOREIGN KEY (`cikkszam`) REFERENCES `termek` (`cikkszam`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
