package com.kindergarten.demo.Models;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Entity
public class Teacher {

  @Id
  @GeneratedValue(strategy = GenerationType.AUTO)
  private Long id;
  private String name;
  private String className;
  private Integer classSize;

  @ManyToMany(mappedBy = "teachers")
  private List<Child> children = new ArrayList<>();

  public Teacher(String name, String className, Integer classSize, List<Child> children) {
    this.name = name;
    this.className = className;
    this.classSize = classSize;
    this.children = children;
  }

  public Long getId() {
    return id;
  }

  public void setId(Long id) {
    this.id = id;
  }

  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public String getClassName() {
    return className;
  }

  public void setClassName(String className) {
    this.className = className;
  }

  public Integer getClassSize() {
    return classSize;
  }

  public void setClassSize(Integer classSize) {
    this.classSize = classSize;
  }

  public List<Child> getChildren() {
    return children;
  }

  public void setChildren(List<Child> children) {
    this.children = children;
  }
}
