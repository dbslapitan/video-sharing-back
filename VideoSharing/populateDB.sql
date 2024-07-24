DELETE FROM "Videos";
DELETE FROM "Users";
DELETE FROM "Bookmarks";

INSERT INTO "Users" ("Username", "Id")
VALUES ('preview', 0);

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (0, 0, 'Beyond Earth', '', 2019, 'Movie', 'PG', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/beyond-earth.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (1, 0, 'Bottom Gear', '', 2021, 'Movie', 'PG', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/bottom-gear.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (2, 0, 'Undiscovered Cities', '', 2019, 'TV Series', 'E', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/undiscovered-cities.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (3, 0, '1998', '', 2021, 'Movie', '18+', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/1998.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (4, 0, 'Dark Side of the Moon', '', 2018, 'TV Series', 'PG', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/dark-side-of-the-moon.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (5, 0, 'The Great Lands', '', 2019, 'Movie', 'E', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/the-great-lands.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (6, 0, 'The Diary', '', 2019, 'TV Series', 'PG', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/the-diary.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (7, 0, 'Earth’s Untouched', '', 2017, 'Movie', '18+', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/earths-untouched.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (8, 0, 'No Land Beyond', '', 2019, 'Movie', 'E', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/no-land-beyond.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (9, 0, 'During the Hunt', '', 2016, 'TV Series', 'PG', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/during-the-hunt.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (10, 0, 'Autosport the Series', '', 2016, 'TV Series', '18+', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/autosport-the-series.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (11, 0, 'Same Answer II', '', 2017, 'Movie', 'E', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/same-answer-2.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (12, 0, 'Below Echo', '', 2016, 'TV Series', 'PG', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/below-echo.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (13, 0, 'The Rockies', '', 2015, 'TV Series', 'E', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/the-rockies.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (14, 0, 'Relentless', '', 2017, 'Movie', 'PG', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/relentless.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (15, 0, 'Community of Ours', '', 2018, 'TV Series', '18+', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/community-of-ours.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (16, 0, 'Van Life', '', 2015, 'Movie', 'PG', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/van-life.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (17, 0, 'The Heiress', '', 2021, 'Movie', 'PG', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/the-heiress.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (18, 0, 'Off the Track', '', 2017, 'Movie', '18+', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/off-the-track.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (19, 0, 'Whispering Hill', '', 2017, 'Movie', 'E', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/whispering-hill.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (20, 0, '112', '', 2013, 'TV Series', 'PG', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/112.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (21, 0, 'Lone Heart', '', 2017, 'Movie', 'E', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/lone-heart.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (22, 0, 'Production Line', '', 2018, 'TV Series', 'PG', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/production-line.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (23, 0, 'Dogs', '', 2016, 'TV Series', 'E', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/dogs.jpg');

INSERT INTO "Videos" ( "Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (24, 0, 'Asia in 24 Days', '', 2020, 'TV Series', 'PG', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/asia-in-24-days.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (25, 0, 'The Tasty Tour', '', 2016, 'TV Series', 'PG', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/the-tasty-tour.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (26, 0, 'Darker', '', 2017, 'Movie', '18+', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/darker.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (27, 0, 'Unresolved Cases', '', 2018, 'TV Series', '18+', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/unresolved-cases.jpg');

INSERT INTO "Videos" ("Id", "UserId", "Title", "Description", "Year", "Category", "Rating", "Source")
VALUES (28, 0, 'Mission: Saturn', '', 2017, 'Movie', 'PG', 'https://video-sharing-preview.s3.ca-central-1.amazonaws.com/mission-saturn.jpg');

INSERT INTO "Bookmarks" ("UserId", "VideoId")
VALUES ( 0, 4);

INSERT INTO "Bookmarks" ("UserId", "VideoId")
VALUES ( 0, 7);

INSERT INTO "Bookmarks" ("UserId", "VideoId")
VALUES ( 0, 13);

INSERT INTO "Bookmarks" ("UserId", "VideoId")
VALUES ( 0, 17);

INSERT INTO "Bookmarks" ("UserId", "VideoId")
VALUES ( 0, 18);

INSERT INTO "Bookmarks" ("UserId", "VideoId")
VALUES ( 0, 21);

INSERT INTO "Bookmarks" ("UserId", "VideoId")
VALUES ( 0, 23);

INSERT INTO "Bookmarks" ("UserId", "VideoId")
VALUES ( 0, 26);

INSERT INTO "Bookmarks" ("UserId", "VideoId")
VALUES ( 0, 28);