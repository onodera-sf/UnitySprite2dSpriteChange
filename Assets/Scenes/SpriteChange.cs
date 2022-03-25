using UnityEngine;

public class SpriteChange : MonoBehaviour
{
  /// <summary>�摜��ύX����X�v���C�g�I�u�W�F�N�g�B</summary>
  [SerializeField] private GameObject TargetSprite;

  /// <summary>�ύX��̉摜�����X�v���C�g�B</summary>
  [SerializeField] private Sprite NextSprite;

  /// <summary>�{�^�����N���b�N�����Ƃ��ɌĂ΂�܂��B</summary>
  public void OnClick()
  {
    if (TargetSprite == null)
    {
      Debug.Log($"{nameof(TargetSprite)} �� null �ł��B");
      return;
    }
    if (NextSprite == null)
    {
      Debug.Log($"{nameof(NextSprite)} �� null �ł��B");
      return;
    }

    // �ύX�Ώۂ̃I�u�W�F�N�g������ SpriteRenderer ���擾
    var spriteRenderer = TargetSprite.GetComponent<SpriteRenderer>();
    if (spriteRenderer == null)
    {
      Debug.Log($"{nameof(TargetSprite)} �� {nameof(SpriteRenderer)} �R���|�[�l���g������܂���B");
      return;
    }

    // SpriteRenderer �� sprite �ɕύX��̃X�v���C�g���Z�b�g
    spriteRenderer.sprite = NextSprite;
  }
}
