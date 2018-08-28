package com.kindergarten.demo.Models;

import com.sun.xml.internal.ws.api.ha.StickyFeature;
import org.springframework.web.bind.annotation.GetMapping;

import javax.persistence.*;

@Entity
public class Address {

  @Id
  @GeneratedValue(strategy = GenerationType.AUTO)
  private Long id;
  private String city;
  private String street;
  private String zipCode;

  @OneToOne
  private Parent parent;

  public Address() {
  }

  public Address(Long id, String city, String street, String zipCode, Parent parent) {
    this.id = id;
    this.city = city;
    this.street = street;
    this.zipCode = zipCode;
    this.parent = parent;
  }

  public Long getId() {
    return id;
  }

  public void setId(Long id) {
    this.id = id;
  }

  public String getCity() {
    return city;
  }

  public void setCity(String city) {
    this.city = city;
  }

  public String getStreet() {
    return street;
  }

  public void setStreet(String street) {
    this.street = street;
  }

  public String getZipCode() {
    return zipCode;
  }

  public void setZipCode(String zipCode) {
    this.zipCode = zipCode;
  }

  public Parent getParent() {
    return parent;
  }

  public void setParent(Parent parent) {
    this.parent = parent;
  }
}
