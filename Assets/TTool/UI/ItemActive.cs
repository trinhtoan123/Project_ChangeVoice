using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace TQT.UI
{
    public class ItemActive : Item
    {
        private Sequence currentSequence;
        private bool isShow = false,
            isPlay = false;
        public override bool IsShow => isShow;

        public override bool IsPlay => isPlay;

        public override void SetHide()
        {
            KillCurrentSequence();
            //
            isShow = false;
            isPlay = false;
            gameObject.SetActive(false);
        }

        public override void SetShow()
        {
            KillCurrentSequence();
            //
            isShow = true;
            isPlay = false;
            gameObject.SetActive(true);
        }
        public override void PlayShow(float delay, bool unScaleTime)
        {
            KillCurrentSequence();
            isShow = true;
            //
            if (delay > 0)
            {
                isPlay = true;
                currentSequence = DOTween.Sequence();
                if (unScaleTime)
                    currentSequence.SetUpdate(true);
                currentSequence.AppendInterval(delay);
                currentSequence.onComplete += (() =>
                {
                    currentSequence = null;
                    isPlay = false;
                    gameObject.SetActive(true);
                });
            }
            else
            {
                isPlay = false;
                gameObject.SetActive(true);
            }
        }
        public override void PlayHide(float delay, bool unScaleTime)
        {
            KillCurrentSequence();
            isShow = false;
            //
            if (delay > 0)
            {
                isPlay = true;
                currentSequence = DOTween.Sequence();
                if (unScaleTime)
                    currentSequence.SetUpdate(true);
                currentSequence.AppendInterval(delay);
                currentSequence.onComplete += (() =>
                {
                    currentSequence = null;
                    isPlay = false;
                    gameObject.SetActive(false);
                });
            }
            else
            {
                isPlay = false;
                gameObject.SetActive(false);
            }
        }

        private void KillCurrentSequence()
        {
            if (currentSequence == null)
                return;
            if (currentSequence.IsPlaying())
                currentSequence.Kill(false);
            currentSequence = null;
        }


    }
}

