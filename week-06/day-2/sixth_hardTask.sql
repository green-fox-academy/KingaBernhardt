
SELECT reviewer.name, movie.title
FROM movie INNER JOIN rating a, rating b
ON movie.mID = a.mID
INNER JOIN reviewer
ON a.rID = reviewer.rID
AND a.mID = b.mID AND a.rID = b.rID AND a.stars<b.stars AND a.ratingdate<b.ratingdate;
