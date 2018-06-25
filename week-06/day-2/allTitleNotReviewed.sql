Find the titles of all movies not reviewed by Chris Jackson. SELECT movie.title, notReviewed.title FROM movie
LEFT JOIN (SELECT movie.title, movie.mID, reviewer.name
FROM movie
LEFT JOIN rating
ON movie.mID = rating.mID
LEFT JOIN reviewer
ON reviewer.rID = rating.rID
WHERE reviewer.name LIKE "Chris Jackson") notReviewed
ON movie.mID = notReviewed.mID
WHERE notReviewed.title IS NULL;
