package sync.bddg

import org.rosi_project.model_management.core.PlayerSync

class BDD(protected var name: String, protected var trees: Set[Tree], protected var root: Tree, protected var ports: Set[Port]) extends PlayerSync {

  def getName(): String = {
    name
  }

  def setName(n: String): Unit = {
    name = n
    +this changeName ()
  }

  def getTrees(): Set[Tree] = {
    trees
  }

  def setTrees(t: Set[Tree]): Unit = {
    trees = t
    +this changeTrees ()
  }

  def addTrees(t: Tree): Unit = {
    trees += t
    +this changeTrees ()
  }

  def getRoot(): Tree = {
    root
  }

  def setRoot(r: Tree): Unit = {
    root = r
    +this changeRoot ()
  }

  def getPorts(): Set[Port] = {
    ports
  }

  def setPorts(p: Set[Port]): Unit = {
    ports = p
    +this changePorts ()
  }

  def addPorts(p: Port): Unit = {
    ports += p
    +this changePorts ()
  }

  override def toString(): String = {
    "BDD:" + " name=" + name
  }

}



    