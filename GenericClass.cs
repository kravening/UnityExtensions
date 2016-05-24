using UnityEngine;
using System.Collections;

public class GenericClass <T>{

	public T GenericMethod<T>(T param){
		return param;
	}
}
