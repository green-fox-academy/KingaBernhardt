SELECT DISTINCT reviewer.name, movie.title, rating.stars, rating.ratingdate
FROM reviewer, movie, rating
ON reviewer.rID = rating.rID
AND movie.mID = rating.mID
ORDER BY reviewer.name ASC;
