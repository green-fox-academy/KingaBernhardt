/*For any rating where the reviewer is the same as the director of the movie, return the reviewer name, movie title, and number of stars.*/
SELECT DISTINCT reviewer.name, movie.title, rating.stars
FROM reviewer, movie, rating
ON reviewer.rID = rating.rID
AND rating.mID = movie.mID
WHERE reviewer.name = movie.director;
