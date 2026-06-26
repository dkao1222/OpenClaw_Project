# Third-Party Asset License Register

## 繁體中文

- Default decision: 本 MVP 交付預設使用 self-generated project assets，不直接內嵌 OpenGameArt 或其他第三方下載素材。
- OpenGameArt reference: OpenGameArt 可作為圖庫、音效與美術方向參考，但每個實際導入的 asset 必須獨立記錄 author、URL、exact license、attribution、modified flag、store decision、implementation path 與 QA evidence。
- Mobile store policy: App Store / Google Play / ad-monetized build 預設允許 self-generated、CC0、OGA-BY；CC-BY 需 review；GPL、LGPL、CC-BY-SA、unknown/custom license 預設 blocked，除非取得作者明確授權與法務確認。
- Preview rule: 不可使用 OpenGameArt preview image/audio，除非該 preview 明確包含在可下載檔案且同授權釋出。
- Attribution: 任何需要署名的素材必須同步寫入 credits screen/file，並在此 register 留下 exact attribution text。

## Asset Register

| Asset | Type | Author | Source URL | License | Attribution | Modified | Store Decision | Implementation Path | QA Evidence |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| Project-generated app icon/background/font/VFX | visual/audio placeholder | OpenClaw generated | local pipeline | self-generated | not required | yes | allowed | assets/* and unity/NeonDrift/Assets/* | status/validation/visual_assets_validation.md |

## English

- Default decision: this MVP delivery uses self-generated project assets by default and does not directly embed OpenGameArt or other third-party downloaded assets.
- OpenGameArt reference: OpenGameArt may be used as an art, SFX, and music reference, but every imported asset must record author, URL, exact license, attribution, modified flag, store decision, implementation path, and QA evidence.
- Mobile store policy: App Store / Google Play / ad-monetized builds allow self-generated, CC0, and OGA-BY by default; CC-BY requires review; GPL, LGPL, CC-BY-SA, and unknown/custom licenses are blocked by default unless explicit author permission and legal review exist.
- Preview rule: do not use OpenGameArt preview image/audio unless the preview is included in the downloadable asset package and released under the same license.
- Attribution: every attribution-required asset must be added to the credits screen/file and this register with exact attribution text.
