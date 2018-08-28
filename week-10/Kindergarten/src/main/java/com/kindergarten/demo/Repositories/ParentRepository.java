package com.kindergarten.demo.Repositories;

import com.kindergarten.demo.Models.Parent;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface ParentRepository extends CrudRepository<Parent, Long> {
}
