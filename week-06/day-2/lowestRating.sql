For each rating that is the lowest (fewest stars) currently in the database, return the reviewer name, movie title, and number of stars.
SELECT reviewer.name, movie.title, rating.stars
FROM reviewer
INNER JOIN rating
ON reviewer.rID = rating.rID
INNER JOIN movie
ON movie.mID = rating.mID
WHERE rating.stars =
(SELECT MIN(rating.stars)
FROM rating)

