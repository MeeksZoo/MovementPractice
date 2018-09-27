	using UnityEngine; 
 
	[RequireComponent(typeof(CharacterController))] 
	public class CharacterMover : MonoBehaviour 
	{ 
		private CharacterController controller; 
		private Vector3 position, rotation; 
		public float Speed = 3.0f, JumpSpeed = 4.0f, Gravity = 9.81f; 
 
		void Start() 
		{ 
			controller = GetComponent<CharacterController>(); 
		} 
 
		void Update() 
		{ 
			if (controller.isGrounded) 
			{ 
				position.Set(X.value, Y.value, Z.value); 
				rotation.Set(Q.value, R.value, S.value); 
				transform.Rotate(rotation); 
				position = transform.TransformDirection(position); 
 
				if (Input.GetButton("Jump")) 
				{ 
					position.y = JumpSpeed; 
				} 
			} 
 
			position.y -= Gravity * Time.deltaTime; 
         
			controller.Move(position * Time.deltaTime); 
}
