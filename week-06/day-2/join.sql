SELECT DISTINCT year FROM movie m, rating r ON r.mID = m.mID WHERE r.stars IN (4,5) ORDER BY m.year ASC;

SELECT DISTINCT m.year FROM movie m, rating r WHERE m.mID = r.rID AND r.stars IN (4,5) ORDER BY m.year ASC;
