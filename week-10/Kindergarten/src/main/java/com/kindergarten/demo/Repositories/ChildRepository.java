package com.kindergarten.demo.Repositories;

import com.kindergarten.demo.Models.Child;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import java.util.Optional;

@Repository
public interface ChildRepository extends CrudRepository<Child, Long> {
}
