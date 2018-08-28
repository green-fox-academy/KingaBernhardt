package com.kindergarten.demo.Models;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Entity
public class Parent {

  @Id
  @GeneratedValue(strategy = GenerationType.AUTO)
  private Long id;
  private String fatherName;
  private String motherName;
  private Integer fatherBirthdate;
  private Integer motherBirthdate;
  @OneToOne
  private Address address;

  @OneToMany(mappedBy = "parent")
  private List<Child> children = new ArrayList<>();

  public Parent() {
  }

  public Parent(String fatherName, String motherName) {
    this.fatherName = fatherName;
    this.motherName = motherName;
  }

  public Long getId() {
    return id;
  }

  public void setId(Long id) {
    this.id = id;
  }

  public String getFatherName() {
    return fatherName;
  }

  public void setFatherName(String fatherName) {
    this.fatherName = fatherName;
  }

  public String getMotherName() {
    return motherName;
  }

  public void setMotherName(String motherName) {
    this.motherName = motherName;
  }

  public List<Child> getChildren() {
    return children;
  }

  public void setChildren(List<Child> children) {
    this.children = children;
  }
}
